#pragma warning disable IDE0130 // 命名空间与文件夹结构不匹配
namespace Mobius.Services;

partial class SppWebApiServiceImplBase
{
    /// <summary>
    /// 设置请求中的授权头
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    protected abstract Task<JWTEntity?> SetRequestHeaderAuthorization(
        HttpRequestMessage request,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 返回 HTTP 401 未授权，清空当前 AuthToken，并调用 SignOut
    /// </summary>
    /// <param name="method"></param>
    /// <param name="requestUri"></param>
    /// <param name="cancellationToken"></param>
    protected abstract Task Unauthorized(HttpMethod method, string requestUri, CancellationToken cancellationToken = default);

    /// <inheritdoc/>
    protected override HttpContentWrapper<TResponseBody> GetCustomSerializeContent<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TResponseBody, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TRequestBody>(
        WebApiClientSendArgs args,
        TRequestBody requestBody,
        string? mime,
        CancellationToken cancellationToken)
    {
        switch (mime)
        {
            case MediaTypeNames.JSONSecurity:
            case MediaTypeNames.MessagePackSecurity:
                throw new NotSupportedException();
            case MediaTypeNames.MemoryPackSecurity:
                {
                    if (args is not SppWebApiClientSendArgs args2)
                        throw new NotSupportedException();
                    var byteArray = Serializable.SMP2(requestBody);
                    if (byteArray == null)
                        return default;
                    var args2_AesInstance = args2.AesInstance;
                    byteArray = args2_AesInstance.ThrowIsNull().Encrypt(byteArray);
                    var httpContent = new ByteArrayContent(byteArray);
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue(
                        MediaTypeNames.MemoryPackSecurity);
                    return httpContent;
                }
            default:
                return base.GetCustomSerializeContent<TResponseBody, TRequestBody>(args, requestBody, mime, cancellationToken);
        }
    }

    async Task GlobalResponseIntercept(
        HttpMethod method,
        string requestUri,
        ApiRspBase response)
    {
        if (!response.IsSuccess)
        {
            if (response.Code == ApiRspCode.Unauthorized)
            {
                await Unauthorized(method, requestUri);
            }
        }
    }

    async Task GlobalResponseIntercept<TResponseModel>(
        bool isApi,
        HttpMethod method,
        string requestUri,
        ApiRspImpl<TResponseModel?> response,
        bool responseContentMaybeNull)
    {
        if (response.IsSuccess)
        {
            if (!responseContentMaybeNull && response.Content == null)
            {
                response.Code = ApiRspCode.NoResponseContent;
            }
            else
            {
                if (isApi)
                {
                    if (!responseContentMaybeNull && response is
                        IApiRsp<IExplicitHasValue?> explicitHasValue &&
                        !explicitHasValue.Content.HasValue())
                    {
                        response.Code = ApiRspCode.NoResponseContentValue;
                    }
                    else
                    {
                        if (response is IApiRsp<ILoginResponse> loginResponse
                              && loginResponse.Content != null)
                        {
                            var apiRspImpl = await OnLoginedAsync(loginResponse.Content, loginResponse.Content);
                            if (!apiRspImpl.IsSuccess)
                            {
                                response.Code = ApiRspCode.SetLoginResponseToUserManagerFail;
                            }
                        }
                        else if (response is IApiRsp<IReadOnlyAuthToken?> authTokenResponse
                            && authTokenResponse.Content != null)
                        {
                            var authToken = authTokenResponse.Content.AuthToken;
                            if (authToken.HasValue())
                            {
                                var apiRspImpl = await SaveAuthTokenAsync(
                                    authToken.ThrowIsNull(nameof(authToken)));
                                if (!apiRspImpl.IsSuccess)
                                {
                                    response.Code = ApiRspCode.SaveAuthTokenToUserManagerFail;
                                }
                            }
                        }
                        //else if (response is IApiRsp<Guid[]> guidsResponse
                        //    && guidsResponse.Content != null)
                        //{
                        //    if (request is IUploadFileSource uploadFile) // 上传单个文件
                        //    {
                        //        HandleUploadFile(uploadFile);
                        //    }
                        //    else if (request is IEnumerable<IUploadFileSource> uploadFiles) // 上传多个文件
                        //    {
                        //        HandleUploadFiles(uploadFiles);
                        //    }
                        //    void HandleUploadFile(params IUploadFileSource[] uploadFiles)
                        //    {
                        //        var uploadFiles_ = uploadFiles.AsEnumerable();
                        //        HandleUploadFiles(uploadFiles_);
                        //    }
                        //    void HandleUploadFiles(IEnumerable<IUploadFileSource> uploadFiles)
                        //    {
                        //        var items = uploadFiles.Where(x => x.HasValue() && x.Available).ToArray();
                        //        if (items.Length != guidsResponse.Content.Length)
                        //        {
                        //            var msg = $"Unequal Length Upload File request: {items.Length}, response: {guidsResponse.Content.Length}";
                        //            logger.LogError(msg);
                        //            throw new ApiRspCodeException(
                        //                ApiRspCode.UnequalLengthUploadFile, msg);
                        //        }
                        //        else
                        //        {
                        //            // 上传后将此缓存文件移动到下载图片文件夹中
                        //            throw new NotImplementedException();
                        //        }
                        //    }
                        //}
                    }
                }
            }
        }
        await GlobalResponseIntercept(method, requestUri, response);
    }

    Task<ApiRspImpl<JWTEntity?>>? RefreshTokenAndAutoSaveTask;

    async Task<ApiRspImpl<JWTEntity?>> RefreshTokenAndAutoSave(JWTEntity jwt)
    {
        var rsp = await RefreshTokenCore(jwt);
        if (rsp.Code != ApiRspCode.Unauthorized)
        {
            logger.LogWarning("RefreshToken fail, Code: {code}", rsp.Code);
            return rsp;
        }
        else if (!rsp.IsSuccess)
        {
            return rsp;
        }
        else if (rsp.Content == null)
        {
            return ApiRspCode.NoResponseContent;
        }
        else
        {
            var rsp2 = await SaveAuthTokenAsync(rsp.Content);
            if (!rsp2.IsSuccess)
            {
                return ApiRspHelper.Create<JWTEntity>(rsp2);
            }
            else if (rsp2.Content == null)
            {
                return ApiRspCode.NoResponseContent;
            }
            else
            {
                return rsp;
            }
        }
    }

    async Task<ApiRspImpl<JWTEntity?>> RefreshToken(JWTEntity jwt)
    {
        RefreshTokenAndAutoSaveTask ??= RefreshTokenAndAutoSave(jwt);
        var r = await RefreshTokenAndAutoSaveTask;
        return r;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static bool IsAppObsolete(HttpResponseHeaders headers)
        => headers.TryGetValues(ApiConstants.Headers.Response.AppObsolete, out var values) &&
            values.Contains(String2.TrueLowerString, StringComparer.OrdinalIgnoreCase);

    void HandleHttpRequest(HttpRequestMessage request)
    {
        var acceptLanguage = httpPlatformHelper?.AcceptLanguage;
        if (!string.IsNullOrWhiteSpace(acceptLanguage))
        {
            request.Headers.AcceptLanguage.ParseAdd(acceptLanguage);
        }
        request.Headers.Referrer = Referrer;
    }

    /// <inheritdoc/>
    protected override HttpHandlerCategory Category => ISppWebApiService.DefaultHttpHandlerCategory;

    /// <inheritdoc/>
    protected override async Task<(bool isIntercept, TResponseBody? responseBody)> HandleHttpResponseMessage<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TResponseBody, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TRequestBody>(
        HttpResponseMessage response,
        WebApiClientSendArgs args,
        TRequestBody requestBody,
        CancellationToken cancellationToken = default)
        where TResponseBody : default
    {
        await Task.CompletedTask;
        if (args is SppWebApiClientSendArgs args2)
        {
            if (IsAppObsolete(response.Headers))
            {
                args2.Code = ApiRspCode.AppObsolete;
                return (true, default);
            }
            if (args2.ShopApiDeserialize != null)
            {
                var result = await args2.ShopApiDeserialize(this, response, cancellationToken);
                if (result is TResponseBody responseBody)
                {
                    return (true, responseBody);
                }
            }
        }
        return (false, default);
    }

    async Task<ApiRspImpl<TResponseModel?>> SendCoreWithOutOfflineAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TRequestModel, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TResponseModel>(
        bool isAnonymous,
        bool isApi,
        CancellationToken cancellationToken,
        HttpMethod method,
        string requestUri,
        TRequestModel? requestModel,
        bool responseContentMaybeNull,
        bool isSecurity,
        HttpHandlerCategory category,
        Func<WebApiClientService, HttpResponseMessage, CancellationToken, Task<object?>>? shopApiDeserialize = null)
        where TRequestModel : notnull
    {
        var hasRequestModel = requestModel != null && typeof(TRequestModel) != typeof(object) && typeof(TRequestModel) != typeof(nil);
        var isShopApi = requestModel is IShopBaseRequest || shopApiDeserialize != null;

        #region ModelValidator

        if (!ISppWebApiService.DisableModelValidator && isApi && hasRequestModel)
        {
            if (!modelValidator.Validate(requestModel!, out var errorMessage))
            {
                var validate_fail_r = ApiRspHelper.Code<TResponseModel>(
                    ApiRspCode.RequestModelValidateFail, errorMessage);
                return validate_fail_r;
            }
        }

        #endregion

        SppWebApiClientSendArgs? args = null;
        ApiRspImpl<TResponseModel?>? responseResult;

        Aes? aes = null;

        try
        {
            if (isSecurity)
            {
                // 行业标准加密
                aes = AESUtils.Create();
            }

            JWTEntity? jwt = null;
            var serializableImplType = isShopApi ?
                Serializable.ImplType.SystemTextJson :
                ISppWebApiService.SerializableImplType;
            args = new(requestUri)
            {
                Method = method,
                AesInstance = aes,
                ConfigureRequestMessage = async (request, _, _) =>
                {
                    if (isSecurity)
                    {
                        var skey_bytes = aes!.ToParamsByteArray();
                        var padding = RSAUtils.DefaultPadding;
                        var skey_str = RSAInstance.EncryptToHexString(skey_bytes, padding);
                        request.Headers.Add(ApiConstants.Headers.Request.SecurityKeyHex, skey_str);
                        request.Headers.Add(ApiConstants.Headers.Request.SecurityKeyPadding,
                            padding.OaepHashAlgorithm.ToString() ?? string.Empty);
                    }

                    if (!isAnonymous)
                    {
                        jwt = await SetRequestHeaderAuthorization(request, cancellationToken);
                    }
                },
                IsShopApi = isShopApi,
                ShopApiDeserialize = shopApiDeserialize,
            };
            args.SetSerializableImplType(serializableImplType);
            var client = CreateClient(category);
            args.SetHttpClient(client);

            if (hasRequestModel)
            {
                responseResult = await SendAsync<ApiRspImpl<TResponseModel?>, TRequestModel>(args, requestModel!, cancellationToken);
            }
            else
            {
                responseResult = await SendAsync<ApiRspImpl<TResponseModel?>>(args, cancellationToken);
            }
            responseResult ??= ApiRspHelper.Code<TResponseModel>(args.Code == default ? ApiRspCode.NoResponseContent : args.Code);

            if (!isAnonymous && responseResult.Code == ApiRspCode.Unauthorized && jwt != null)
            {
                var resultRefreshToken = await RefreshToken(jwt);
                if (resultRefreshToken.IsSuccess)
                {
                    var resultRecursion = await SendCoreWithOutOfflineAsync<TRequestModel, TResponseModel>(
                        isAnonymous,
                        isApi,
                        cancellationToken,
                        method,
                        requestUri,
                        requestModel,
                        responseContentMaybeNull,
                        isSecurity,
                        category: category);
                    return resultRecursion;
                }
            }
        }
        finally
        {
            aes?.Dispose();
        }
        await GlobalResponseIntercept(
            isApi,
            method,
            requestUri,
            responseResult,
            responseContentMaybeNull);
        return responseResult;
    }

    /// <inheritdoc/>
    protected override async Task<TResponseBody?> ReadFromCustomDeserializeAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TResponseBody>(
        WebApiClientSendArgs args,
        HttpResponseMessage responseMessage,
        string? mime,
        CancellationToken cancellationToken = default) where TResponseBody : default
    {
        if (args is SppWebApiClientSendArgs args2)
        {
            TResponseBody? deserializeResult;
            switch (mime)
            {
                case MediaTypeNames.JSONSecurity:
                    throw new NotSupportedException();
                case MediaTypeNames.MessagePackSecurity:
                    deserializeResult = await ReadFromMessagePackAsync<TResponseBody>(
                        responseMessage.Content, args2.AesInstance.ThrowIsNull(), cancellationToken: cancellationToken);
                    return deserializeResult;
                case MediaTypeNames.MemoryPackSecurity:
                    deserializeResult = await ReadFromMemoryPackAsync<TResponseBody>(
                        responseMessage.Content, args2.AesInstance.ThrowIsNull(), cancellationToken: cancellationToken);
                    return deserializeResult;
            }
        }

        return await base.ReadFromCustomDeserializeAsync<TResponseBody>(args, responseMessage, mime, cancellationToken);
    }

    async Task<ApiRspImpl<TResponseModel?>> SendCoreAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TRequestModel, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TResponseModel>(
        bool isAnonymous,
        bool isApi,
        CancellationToken cancellationToken,
        HttpMethod method,
        string requestUri,
        TRequestModel? requestModel,
        bool responseContentMaybeNull,
        bool isSecurity,
        HttpHandlerCategory category,
        Func<WebApiClientService, HttpResponseMessage, CancellationToken, Task<object?>>? shopApiDeserialize = null)
        where TRequestModel : notnull
    {
        var response = await SendCoreWithOutOfflineAsync<TRequestModel, TResponseModel>(
                isAnonymous,
                isApi,
                cancellationToken,
                method,
                requestUri,
                requestModel,
                responseContentMaybeNull,
                isSecurity,
                category: category,
                shopApiDeserialize: shopApiDeserialize);

        if (!response.IsSuccess) // 失败时候尝试请求缓存
        {
            // https://github.com/reactiveui/Fusillade/blob/2.4.67/src/Fusillade/RateLimitedHttpMessageHandler.cs#L106
            if (!isSecurity && category != HttpHandlerCategory.Offline && (method == HttpMethod.Get ||
                method == HttpMethod.Head ||
                method == HttpMethod.Options))
            {
                category = HttpHandlerCategory.Offline;
                var responseByOffline = await SendCoreWithOutOfflineAsync<TRequestModel, TResponseModel>(
                    isAnonymous,
                    isApi,
                    cancellationToken,
                    method,
                    requestUri,
                    requestModel,
                    responseContentMaybeNull,
                    isSecurity,
                    category: category,
                    shopApiDeserialize: shopApiDeserialize);
                if (responseByOffline.IsSuccess)
                {
                    return responseByOffline;
                }
            }
        }

        return response;
    }

    /// <inheritdoc/>
    public async Task<ApiRspImpl<TResponseModel?>> SendAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TRequestModel, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TResponseModel>(
        CancellationToken cancellationToken,
        HttpMethod method,
        string requestUri,
        TRequestModel? request,
        bool responseContentMaybeNull,
        bool isSecurity,
        bool isAnonymous,
        HttpHandlerCategory category)
        where TRequestModel : notnull
    {
        var rsp = await SendCoreAsync<TRequestModel, TResponseModel>(
            isAnonymous: isAnonymous,
            isApi: true,
            cancellationToken,
            method,
            requestUri,
            requestModel: request,
            responseContentMaybeNull,
            isSecurity,
            category);
        return rsp;
    }

    /// <inheritdoc/>
    public async Task<ApiRspImpl<nil>> SendAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TRequestModel>(
        CancellationToken cancellationToken,
        HttpMethod method,
        string requestUri,
        TRequestModel? request,
        bool isSecurity,
        bool isAnonymous,
        HttpHandlerCategory category)
        where TRequestModel : notnull
    {
        var rsp = await SendCoreAsync<TRequestModel, nil>(
            isAnonymous: isAnonymous,
            isApi: true,
            cancellationToken,
            method,
            requestUri,
            requestModel: request,
            responseContentMaybeNull: true,
            isSecurity,
            category);
        return rsp;
    }

    /// <inheritdoc/>
    public async Task<ApiRspImpl<nil>> SendAsync(
        CancellationToken cancellationToken,
        HttpMethod method,
        string requestUri,
        bool isAnonymous,
        HttpHandlerCategory category)
    {
        var rsp = await SendCoreAsync<nil, nil>(
            isAnonymous: isAnonymous,
            isApi: true,
            cancellationToken,
            method,
            requestUri,
            requestModel: default,
            responseContentMaybeNull: true,
            isSecurity: false,
            category);
        return rsp;
    }

    /// <inheritdoc/>
    public async Task<ApiRspImpl<TResponseModel?>> SendAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TResponseModel>(
        CancellationToken cancellationToken,
        HttpMethod method,
        string requestUri,
        bool responseContentMaybeNull,
        bool isSecurity,
        bool isAnonymous,
        HttpHandlerCategory category)
    {
        var rsp = await SendCoreAsync<nil, TResponseModel>(
            isAnonymous: isAnonymous,
            isApi: true,
            cancellationToken,
            method,
            requestUri,
            requestModel: default,
            responseContentMaybeNull,
            isSecurity,
            category);
        return rsp;
    }

    /// <inheritdoc/>
    public async Task<ApiRspImpl<TResponseModel?>> SendShopAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TRequestModel, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TResponseModel>(
        CancellationToken cancellationToken,
        HttpMethod method,
        string requestUri,
        TRequestModel? request,
        bool responseContentMaybeNull,
        bool isAnonymous,
        HttpHandlerCategory category)
        where TRequestModel : notnull
    {
        var rsp = await SendCoreAsync<TRequestModel, TResponseModel>(
            isAnonymous: isAnonymous,
            isApi: true,
            cancellationToken,
            method,
            requestUri,
            requestModel: request,
            responseContentMaybeNull,
            isSecurity: false,
            category: category,
            shopApiDeserialize: SppWebApiClientSendArgs.ShopApiDeserializeImpl<TResponseModel>);
        return rsp;
    }

    /// <inheritdoc/>
    public async Task<ApiRspImpl<ResultResponse<TResponseModel, TResponseOtherDataModel>?>> SendShopAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TRequestModel, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TResponseModel, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TResponseOtherDataModel>(
        CancellationToken cancellationToken,
        HttpMethod method,
        string requestUri,
        TRequestModel? request,
        bool responseContentMaybeNull,
        bool isAnonymous,
        HttpHandlerCategory category)
        where TRequestModel : notnull
    {
        var rsp = await SendCoreAsync<TRequestModel, ResultResponse<TResponseModel, TResponseOtherDataModel>>(
            isAnonymous: isAnonymous,
            isApi: true,
            cancellationToken,
            method,
            requestUri,
            requestModel: request,
            responseContentMaybeNull,
            isSecurity: false,
            category: category,
            shopApiDeserialize: SppWebApiClientSendArgs.ShopApiDeserializeImpl<TResponseModel, TResponseOtherDataModel>);
        return rsp;
    }
}
