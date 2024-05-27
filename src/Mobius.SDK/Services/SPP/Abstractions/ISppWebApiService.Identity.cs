namespace Mobius.Services.SPP.Abstractions;

static partial class SppWebApiServiceExtensions
{
    /// <summary>
    /// 登录或注册
    /// </summary>
    /// <param name="s"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    internal static async Task<ApiRspImpl<LoginOrRegisterResponse?>> AccountLoginOrRegister(
        this ISppWebApiService s,
        LoginOrRegisterRequest request)
    {
#if DEBUG
        if (s.IsDesignMode)
            return "IsDesignMode";
#endif

        var r = await s.SendAsync<LoginOrRegisterRequest, LoginOrRegisterResponse>(
              isAnonymous: true,
              isSecurity: true,
              method: HttpMethod.Post,
              requestUri: "identity/v1/account/loginorregister",
              request: request,
              cancellationToken: default,
              responseContentMaybeNull: false);
        return r;
    }

    /// <summary>
    /// 刷新 JWT
    /// </summary>
    /// <param name="s"></param>
    /// <param name="refresh_token"></param>
    /// <returns></returns>
    public static async Task<ApiRspImpl<JWTEntity?>> AccountRefreshToken(
        this ISppWebApiService s,
        string refresh_token)
    {
#if DEBUG
        if (s.IsDesignMode)
            return "IsDesignMode";
#endif

        var r = await s.SendAsync<RefreshTokenRequest, JWTEntity>(
                isAnonymous: true, // 刷新 Token 必须匿名身份，否则将在客户端上递归导致死循环
                isSecurity: true,
                method: HttpMethod.Post,
                requestUri: "identity/account/refreshtoken",
                request: new()
                {
                    RefreshToken = refresh_token,
                },
                cancellationToken: default,
                responseContentMaybeNull: true);
        return r;
    }

    /// <summary>
    /// 删除账号
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    internal static async Task<ApiRspImpl<nil>> DeleteAccount(
        this ISppWebApiService s)
    {
#if DEBUG
        if (s.IsDesignMode)
            return ApiRspHelper.Ok<nil>();
#endif

        var r = await s.SendAsync(
                isAnonymous: false,
                method: HttpMethod.Delete,
                requestUri: "identity/manage/deleteaccount",
                cancellationToken: default);
        return r;
    }

    /// <summary>
    /// 登出，退出登录
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    internal static async Task<ApiRspImpl<nil>> SignOut(
        this ISppWebApiService s)
    {
#if DEBUG
        if (s.IsDesignMode)
            return ApiRspHelper.Ok<nil>();
#endif

        var r = await s.SendAsync(
                isAnonymous: false,
                method: HttpMethod.Get,
                requestUri: "identity/manage/signout",
                cancellationToken: default);
        return r;
    }

    /// <summary>
    /// 刷新用户信息
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    internal static async Task<ApiRspImpl<UserInfoModel?>> RefreshUserInfo(
        this ISppWebApiService s)
    {
#if DEBUG
        if (s.IsDesignMode)
            return "IsDesignMode";
#endif

        var r = await s.SendAsync<UserInfoModel>(
                isAnonymous: false,
                isSecurity: true,
                method: HttpMethod.Get,
                requestUri: "identity/v1/manage/refreshuserinfo",
                cancellationToken: default);
        return r;
    }
}