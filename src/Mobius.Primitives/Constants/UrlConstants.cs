namespace Mobius.Constants;

/// <summary>
/// Url 常量
/// </summary>
public static partial class UrlConstants
{
#if !PROJ_SETUP
    /// <summary>
    /// 微软应用商店包 Id
    /// </summary>
    public const string MicrosoftStoreId = "9MTCFHS560NG";

    /// <summary>
    /// https://store.steampowered.com/app/2425030
    /// </summary>
    public const uint SteamAppId = 2425030;

    /// <summary>
    /// spp
    /// </summary>
    public const string CUSTOM_URL_SCHEME_NAME = "spp";

    /// <summary>
    /// spp://
    /// </summary>
    public const string CUSTOM_URL_SCHEME = $"{CUSTOM_URL_SCHEME_NAME}://";

    /// <summary>
    /// Logo 网址
    /// </summary>
    public static string OfficialWebsite_Logo => $"{OfficialWebsite}/logo.svg";

    /// <summary>
    /// 隐私政策网址
    /// </summary>
    public static string OfficialWebsite_Privacy => $"{OfficialWebsite}/privacy";

    /// <summary>
    /// 用户协议网址
    /// </summary>
    public static string OfficialWebsite_Agreement => $"{OfficialWebsite}/agreement";

    /// <summary>
    /// 联系我们网址
    /// </summary>
    public static string OfficialWebsite_Contact => $"{OfficialWebsite}/contact";

    /// <summary>
    /// 常见问题网址
    /// </summary>
    public static string OfficialWebsite_Faq => $"{OfficialWebsite}/faq";

    /// <summary>
    /// 加入我们网址
    /// </summary>
    public static string OfficialWebsite_JoinUs => $"{OfficialWebsite}/joinus";

    /// <summary>
    /// 更新日志网址
    /// </summary>
    public static string OfficialWebsite_Changelog => $"{OfficialWebsite}/changelog";

    /// <summary>
    /// 更新日志网址（内嵌页）
    /// </summary>
    public static string OfficialWebsite_Box_Changelog_ => $"{OfficialWebsite}/changelogbox?theme={{0}}&language={{1}}";

    /// <summary>
    /// 常见问题网址（内嵌页）
    /// </summary>
    public static string OfficialWebsite_Box_Faq_ => $"{OfficialWebsite}/faqbox?theme={{0}}&language={{1}}";

    /// <summary>
    /// 隐私政策网址（内嵌页）
    /// </summary>
    public static string OfficialWebsite_Box_Privacy => $"{OfficialWebsite}/PrivacyBox";

    /// <summary>
    /// 用户协议网址（内嵌页）
    /// </summary>
    public static string OfficialWebsite_Box_Agreement => $"{OfficialWebsite}/AgreementBox";

    /// <summary>
    /// Liunx 证书导入文档网址
    /// </summary>
    public static string OfficialWebsite_LiunxSetupCer => $"{OfficialWebsite}/liunxSetupCer";

    /// <summary>
    /// Unix Host 文件权限文档网址（带端口号参数）
    /// </summary>
    public static string OfficialWebsite_UnixHostAccess_ => $"{OfficialWebsite}/unixhostaccess?prot={{0}}";

    /// <summary>
    /// Unix Host 文件权限文档网址
    /// </summary>
    public static string OfficialWebsite_UnixHostAccess => $"{OfficialWebsite}/unixhostaccess";

    /// <summary>
    /// 应用程序更新失败文档网址（带错误码）
    /// </summary>
    public static string OfficialWebsite_AppUpdateFailCode_ => $"{OfficialWebsite}?appUpdFailCode={{0}}";

    /// <summary>
    /// 通知网址
    /// </summary>
    public static string OfficialWebsite_Notice => $"{OfficialWebsite}/notice?id={{0}}";

    ///// <summary>
    ///// 上传发布文件地址
    ///// </summary>
    //public static string OfficialWebsite_UploadsPublishFiles => $"{OfficialWebsite}/uploads/publish/files/{{0}}{FileEx.BIN}";

    ///// <summary>
    ///// 上传发布包地址
    ///// </summary>
    //public static string OfficialWebsite_UploadsPublish => $"{OfficialWebsite}/uploads/publish/{{0}}";

    /// <summary>
    /// 账号中心网址
    /// </summary>
    public static string OfficialWebsite_Account_Center => $"{OfficialWebsite}/account/center/info";

    /// <summary>
    /// 账号绑定网址
    /// </summary>
    public static string OfficialWebsite_Account_Bind => $"{OfficialWebsite}/account/center/bind";

    /// <summary>
    /// 账号安全网址
    /// </summary>
    public static string OfficialWebsite_Account_Safe => $"{OfficialWebsite}/account/center/safe";

    /// <summary>
    /// 赞助网址
    /// </summary>
    public static string OfficialWebsite_Sponsor => $"{OfficialWebsite}/sponsor";

    /// <summary>
    /// 运营文章网址
    /// </summary>
    public static string OfficialWebsite_Article => $"{OfficialWebsite}/article";

    /// <summary>
    /// 运营文章详情网址
    /// </summary>
    public static string OfficialWebsite_Article_Detail_ => $"{OfficialWebsite}/article/detail?id={{0}}";

    /// <summary>
    /// 官网 Web 登录跳转地址
    /// </summary>
    public static string OfficialWebsite_Web_Login_ => $"{OfficialWebsite}/account/login?tk={{0}}&t={{1}}&redirectUrl={{2}}";

    /// <summary>
    /// 微软应用商店应用网址
    /// </summary>
    public const string MicrosoftStoreAppWebsite = "https://www.microsoft.com/store/apps/" + MicrosoftStoreId;

    /// <summary>
    /// 微软应用商店应用协议
    /// </summary>
    public const string MicrosoftStoreProtocolLink = "ms-windows-store://pdp/?productid=" + MicrosoftStoreId;

    /// <summary>
    /// 微软应用商店应用（评论）协议
    /// </summary>
    public const string MicrosoftStoreReviewLink = "ms-windows-store://review/?ProductId=" + MicrosoftStoreId;

#endif

    /// <summary>
    /// 赞助（爱发电）
    /// </summary>
    public const string SponsorUrl_afdian = "https://afdian.com/@rmbgame";

    /// <summary>
    /// 赞助（ko-fi）
    /// </summary>
    public const string SponsorUrl_ko_fi = "https://ko-fi.com/rmbgame";

    /// <summary>
    /// 赞助（patreon）
    /// </summary>
    public const string SponsorUrl_patreon = "https://www.patreon.com/rmbgame";

    /// <summary>
    /// 本地化（crowdin）
    /// </summary>
    public const string CrowdinUrl = "https://crowdin.com/project/steampp";

    /// <summary>
    /// Avalonia UI
    /// </summary>
    public const string AvaloniaUIUrl = "https://avaloniaui.net";
}