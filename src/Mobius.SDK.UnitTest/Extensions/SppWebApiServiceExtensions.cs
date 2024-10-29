namespace Mobius.SDK.UnitTest.Extensions;

/// <summary>
/// <see cref="ISppWebApiService"/> 的扩展方法
/// </summary>
static partial class SppWebApiServiceExtensions
{
    //    /// <summary>
    //    /// 示例
    //    /// </summary>
    //    /// <param name="s"></param>
    //    /// <param name="refresh_token"></param>
    //    /// <returns></returns>
    //    public static async Task<ApiRspImpl<JWTEntity?>> 示例(
    //        this ISppWebApiService s,
    //        string refresh_token)
    //    {
    //#if DEBUG
    //        if (s.IsDesignMode)
    //            return "IsDesignMode";
    //#endif

    //        var r = await s.SendAsync<RefreshTokenRequest, JWTEntity>(
    //                isAnonymous: true, // 刷新 Token 必须匿名身份，否则将在客户端上递归导致死循环
    //                isSecurity: true,
    //                method: HttpMethod.Post,
    //                requestUri: "identity/account/refreshtoken",
    //                request: new()
    //                {
    //                    RefreshToken = refresh_token,
    //                },
    //                cancellationToken: default,
    //                responseContentMaybeNull: true);
    //        return r;
    //    }
}
