namespace Mobius.Services.SPP;

/// <summary>
/// <see cref="ISppWebApiService"/> 的实现类
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="SppWebApiServiceImplBase"/> class.
/// </remarks>
/// <param name="logger"></param>
/// <param name="serviceProvider"></param>
abstract partial class SppWebApiServiceImplBase(IServiceProvider serviceProvider) : WebApiClientFactoryService(serviceProvider.GetRequiredService<ILoggerFactory>().CreateLogger<SppWebApiServiceImplBase>(), serviceProvider), ISppWebApiService
{
    protected readonly IModelValidator modelValidator = serviceProvider.GetRequiredService<IModelValidator>();

    /// <inheritdoc/>
    protected override string ClientName => "SppWebApiS";

    /// <inheritdoc/>
    public abstract bool IsDesignMode { get; }

    protected abstract RSA RSAInstance { get; }

    protected abstract Uri Referrer { get; }

    /// <summary>
    /// 保存用户登录凭证
    /// </summary>
    /// <param name="authToken"></param>
    /// <param name="cancellationToken"></param>
    protected abstract Task<ApiRspImpl<CurrentUser?>> SaveAuthTokenAsync(JWTEntity authToken,
       CancellationToken cancellationToken = default);

    /// <summary>
    /// 保存商城用户登录凭证
    /// </summary>
    /// <param name="authToken"></param>
    /// <param name="cancellationToken"></param>
    protected abstract Task<ApiRspImpl<CurrentUser?>> SaveShopAuthTokenAsync(JWTEntity authToken,
       CancellationToken cancellationToken = default);

    /// <summary>
    /// 当登录完成时
    /// </summary>
    /// <param name="phoneNumber"></param>
    /// <param name="response"></param>
    /// <param name="cancellationToken"></param>
    internal abstract Task<ApiRspImpl> OnLoginedAsync(IReadOnlyPhoneNumber? phoneNumber,
       ILoginResponse response,
       CancellationToken cancellationToken = default);

    /// <summary>
    /// 根据 JWT 模型类获取 HTTP 授权头值
    /// </summary>
    /// <param name="authToken"></param>
    /// <returns></returns>
    public static AuthenticationHeaderValue? GetAuthenticationHeaderValue(JWTEntity? authToken)
    {
        if (authToken.HasValue())
        {
            var authHeaderValue = new AuthenticationHeaderValue(ApiConstants.Basic, authToken?.AccessToken);
            return authHeaderValue;
        }
        return null;
    }

    async Task<ApiRspImpl<JWTEntity?>> RefreshTokenCore(JWTEntity jwt)
    {
        JWTEntity? result = null;
        var refresh_token = jwt.RefreshToken;
        if (!string.IsNullOrWhiteSpace(refresh_token))
        {
            var apiRspResult = await this.AccountRefreshToken(refresh_token);
            return apiRspResult;
        }
        return result;
    }

    HttpClient CreateClient(HttpHandlerCategory? category = null)
    {
        //var client = clientHttpClientFactory.ThrowIsNull().CreateClient(ClientName, category ?? Category);
        // SppWebApi 不支持其他 Category
        var client = clientHttpClientFactory.ThrowIsNull().CreateClient(ClientName, HttpHandlerCategory.Default);
        try
        {
            client.BaseAddress = new(UrlConstants.ApiBaseUrl);
        }
        catch
        {
        }
        return client;
    }

    SystemTextJsonSerializerOptions? _JsonSerializerOptions_ShopApi;

    /// <summary>
    /// 使用的 <see cref="SystemTextJsonSerializerOptions"/>
    /// </summary>
    public SystemTextJsonSerializerOptions UseJsonSerializerOptions_ShopApi
    {
        get
        {
            if (_JsonSerializerOptions_ShopApi == null)
            {
                var baseOptions = UseJsonSerializerOptions;
                baseOptions = new SystemTextJsonSerializerOptions(baseOptions)
                {
                    PropertyNameCaseInsensitive = true,
                };
                _JsonSerializerOptions_ShopApi = baseOptions;
            }
            return _JsonSerializerOptions_ShopApi;
        }
    }
}
