namespace Mobius.Constants;

partial class UrlConstants
{
    #region OfficialWebsite

    /// <summary>
    /// SppWebApi 域名
    /// </summary>
    const string OfficialApiHostName = "api.steampp.net";

    const string OfficialWebsite_Ipv6Only_Development = "https://steampp.mossimo.net:8500";
    const string OfficialWebsite_MSTEST_Development = "https://ms-test.steampp.net";
    const string OfficialWebsite_Production = "https://steampp.net";

    static bool IsOfficialWebsiteUrl(string value) => value switch
    {
        OfficialWebsite_Production or
        OfficialWebsite_MSTEST_Development or
        OfficialWebsite_Ipv6Only_Development => true,
        _ => false,
    };

    static string _OfficialWebsite =
#if DEBUG || USE_DEV_API
#if USE_DEV_MSTEST
        OfficialWebsite_MSTEST_Development;
#else
        OfficialWebsite_Ipv6Only_Development;
#endif

#else
        OfficialWebsite_Production;

#endif

    /// <summary>
    /// 官网网址
    /// </summary>
    public static string OfficialWebsite
    {
        get => _OfficialWebsite;
        private set
        {
            const bool httpsOnly =
#if DEBUG
                false;
#else
                true;
#endif
            if (IsOfficialWebsiteUrl(value) || String2.IsHttpUrl(value, httpsOnly))
                _OfficialWebsite = value;
        }
    }

    #endregion

    #region ApiBaseUrl

    /// <summary>
    /// SppWebApi 正式环境基地址
    /// </summary>
    const string BaseUrl_API_Production = $"{String2.Prefix_HTTPS}{OfficialApiHostName}";

    /// <summary>
    /// SppWebApi 测试环境基地址（MSTEST）
    /// </summary>
    const string BaseUrl_API_MSTEST_Development = "https://ms-test.steampp.net";

    /// <summary>
    /// SppWebApi 测试环境基地址（Ipv6Only）
    /// </summary>
    const string BaseUrl_API_Ipv6Only_Development = "https://steampp.mossimo.net:8800";

    /// <summary>
    /// SppWebApi 本地调试基地址（Debug）
    /// </summary>
    public const string BaseUrl_API_Debug = "https://localhost:5001";

    static bool IsApiBaseUrl(string value) => value switch
    {
        BaseUrl_API_Production or
        BaseUrl_API_MSTEST_Development or
        BaseUrl_API_Ipv6Only_Development or
        BaseUrl_API_Debug => true,
        _ => false,
    };

    static string BaseUrl_API =
#if DEBUG || USE_DEV_API
#if USE_DEV_MSTEST
        BaseUrl_API_MSTEST_Development;
#else
        BaseUrl_API_Ipv6Only_Development;
#endif

#else
        BaseUrl_API_Production;

#endif

    /// <summary>
    /// SppWebApi 基地址
    /// </summary>
    public static string ApiBaseUrl
    {
        get => BaseUrl_API;
        private set
        {
            const bool httpsOnly =
#if DEBUG
                false;
#else
                true;
#endif
            if (IsApiBaseUrl(value) || String2.IsHttpUrl(value, httpsOnly))
            {
                BaseUrl_API = value;
            }
        }
    }

    #endregion

    #region WattGame

    /// <summary>
    /// 商城 Api 域名
    /// </summary>
    const string OfficialShopApiHostName = "shop.api.steampp.net";

    const string OfficialShop_Ipv6Only_Development = "https://steampp.mossimo.net:7500";
    const string OfficialShop_MSTEST_Development = "https://ms-test.steampp.net";
    const string OfficialShop_Production = "https://shop.steampp.net";

    static bool IsWattGame(string value) => value switch
    {
        OfficialShop_Production or
        OfficialShop_MSTEST_Development or
        OfficialShop_Ipv6Only_Development => true,
        _ => false,
    };

    static string _WattGame =
#if DEBUG || USE_DEV_API
#if USE_DEV_MSTEST
        OfficialShop_MSTEST_Development;
#else
        OfficialShop_Ipv6Only_Development;
#endif

#else
        OfficialShop_Production;

#endif

    /// <summary>
    /// 官网网址
    /// </summary>
    public static string WattGame
    {
        get => _WattGame;
        private set
        {
            const bool httpsOnly =
#if DEBUG
                false;
#else
                true;
#endif
            if (IsWattGame(value) || String2.IsHttpUrl(value, httpsOnly))
                _WattGame = value;
        }
    }

    #endregion
}
