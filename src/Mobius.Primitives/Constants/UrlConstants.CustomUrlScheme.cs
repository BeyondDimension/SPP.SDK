namespace Mobius.Constants;

partial class UrlConstants // 自定义 Url 协议
{
    /// <summary>
    /// 用于网页登录 Token 传递 参数是 Base64 编码的 AES 加密后的 Byte[]（自定义 Url 协议）
    /// 解密后是 LoginOrRegisterResponse
    /// </summary>
    public const string Segment_Login = $"{CUSTOM_URL_SCHEME}login/";

    /// <summary>
    /// 快速切换 steam 账号  参数为 steam 用户名（自定义 Url 协议）
    /// </summary>
    public const string Segment_SwitchAccount = $"{CUSTOM_URL_SCHEME}steam/switchaccount/";

    /// <summary>
    /// 挂卡运行指定 steam appid 游戏（自定义 Url 协议）
    /// </summary>
    public const string Segment_FakeApp = $"{CUSTOM_URL_SCHEME}steam/fakeapp/";

    /// <summary>
    /// 管理指定 steam appid 游戏成就（自定义 Url 协议）
    /// </summary>
    public const string Segment_SteamAchievement = $"{CUSTOM_URL_SCHEME}team/achievement/";

    /// <summary>
    /// 管理指定 steam appid 游戏云存档（自定义 Url 协议）
    /// </summary>
    public const string Segment_SteamCloudManager = $"{CUSTOM_URL_SCHEME}steam/cloudmanager/";
}