namespace Mobius.Services;

partial class SppWebApiServiceImplBase
{
    sealed record class SppWebApiClientSendArgs : WebApiClientSendArgs
    {
        public SppWebApiClientSendArgs(WebApiClientSendArgs original) : base(original)
        {
        }

        public SppWebApiClientSendArgs([StringSyntax("Uri")] string requestUriString) : base(requestUriString)
        {
        }

        public SppWebApiClientSendArgs(Uri requestUri, [StringSyntax("Uri")] string? requestUriString = null) : base(requestUri, requestUriString)
        {
        }

        /// <summary>
        /// 是否使用加密传输
        /// </summary>
        public bool IsSecurity => AesInstance != null;

        /// <summary>
        /// 使用序列化类型
        /// </summary>
        public void SetSerializableImplType(Serializable.ImplType serializableImplType)
        {
            mAccept = mContentType = serializableImplType switch
            {
                Serializable.ImplType.MessagePack => IsSecurity ?
                                        MediaTypeNames.MessagePackSecurity :
                                        MediaTypeNames.MessagePack,
                Serializable.ImplType.SystemTextJson => IsSecurity ?
                                        MediaTypeNames.JSONSecurity :
                                        MediaTypeNames.JSON,
                Serializable.ImplType.MemoryPack => IsSecurity ?
                                        MediaTypeNames.MemoryPackSecurity :
                                        MediaTypeNames.MemoryPack,
                _ => throw ThrowHelper.GetArgumentOutOfRangeException(serializableImplType),
            };
        }

        /// <inheritdoc/>
        public override async Task<HttpRequestMessage> GetHttpRequestMessage(WebApiClientService s, CancellationToken cancellationToken = default)
        {
            var request = await base.GetHttpRequestMessage(s, cancellationToken);
            if (s is SppWebApiServiceImplBase s2)
            {
                s2.HandleHttpRequest(request);
            }
            return request;
        }

        /// <inheritdoc cref="ApiRspCode"/>
        public ApiRspCode Code { get; set; }

        /// <inheritdoc cref="AesInstance"/>
        public Aes? AesInstance { get; init; }

        public bool IsShopApi { get; init; }

        Func<WebApiClientService, HttpResponseMessage, CancellationToken, Task<object?>>? mShopApiDeserialize;

        public Func<WebApiClientService, HttpResponseMessage, CancellationToken, Task<object?>>? ShopApiDeserialize
        {
            get => mShopApiDeserialize;
            init
            {
                mShopApiDeserialize = value;
            }
        }

        public static async Task<object?> ShopApiDeserializeImpl<T>(WebApiClientService s, HttpResponseMessage response, CancellationToken cancellationToken = default)
        {
            using var stream = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
#pragma warning disable IL2026 // Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code
#pragma warning disable IL3050 // Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.
            var obj = await SystemTextJsonSerializer.DeserializeAsync<ShopBaseResponse<T>>(stream, ((SppWebApiServiceImplBase)s).UseJsonSerializerOptions_ShopApi, cancellationToken: cancellationToken);
#pragma warning restore IL3050 // Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.
#pragma warning restore IL2026 // Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code
            if (obj == null)
            {
                return ApiRspHelper.Code<T>(ApiRspCode.NoResponseContent);
            }
            if (obj.Status)
            {
                return ApiRspHelper.Ok(obj.Data);
            }
            else
            {
                return ApiRspHelper.Code((ApiRspCode)response.StatusCode, obj.Msg, obj.Data);
            }
        }
    }
}