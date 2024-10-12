using static Mobius.Constants.UrlConstants;

namespace Mobius.Constants;

partial class UrlConstants
{
    #region ApiBaseUrl/SppWebApi

    /// <summary>
    /// Watt Toolkit 官网域名
    /// </summary>
    internal const string OfficialHostName = "steampp.net";

    /// <summary>
    /// SppWebApi 域名
    /// </summary>
    internal const string OfficialApiHostName = "api.steampp.net";

    /// <summary>
    /// 开发环境域名
    /// </summary>
    internal const string OfficialHostName_Development = "ms-test.steampp.net";

    /// <summary>
    /// 开发环境域名（仅 IPV6）
    /// </summary>
    internal const string OfficialHostName_Ipv6Only_Development = "steampp.mossimo.net";

    /// <summary>
    /// SppWebApi 正式环境基地址
    /// </summary>
    internal const string BaseUrl_API_Production = $"{String2.Prefix_HTTPS}{OfficialApiHostName}";

    /// <summary>
    /// SppWebApi 测试环境基地址（MSTEST）
    /// </summary>
    internal const string BaseUrl_API_MSTEST_Development = $"{String2.Prefix_HTTPS}{OfficialHostName_Development}";

    /// <summary>
    /// SppWebApi 测试环境基地址（仅 IPV6）
    /// </summary>
    internal const string BaseUrl_API_Ipv6Only_Development = $"{String2.Prefix_HTTPS}{OfficialHostName_Ipv6Only_Development}:8800";

    /// <summary>
    /// SppWebApi 本地调试基地址（Debug）
    /// </summary>
    public const string BaseUrl_API_Debug = "https://localhost:5001";

    /// <summary>
    /// SppWebApi 基地址
    /// </summary>
    public static string ApiBaseUrl =>
#if PROJ_MOBIUS
        HostConstants_.V.ApiBaseUrl.GetValueOrDefault(UrlConstants_.BaseUrl_API);
#else
        UrlConstants_.BaseUrl_API;
#endif

    #endregion

#if !PROJ_SETUP

    #region OfficialWebsite/官网

    internal const string OfficialWebsite_Ipv6Only_Development = $"{String2.Prefix_HTTPS}{OfficialHostName_Ipv6Only_Development}:8500";
    internal const string OfficialWebsite_MSTEST_Development = $"{String2.Prefix_HTTPS}{OfficialHostName_Development}";
    internal const string OfficialWebsite_Production = $"{String2.Prefix_HTTPS}{OfficialHostName}";

    /// <summary>
    /// 官网网址
    /// </summary>
    public static string OfficialWebsite =>
#if PROJ_MOBIUS
        HostConstants_.V.OfficialWebsite.GetValueOrDefault(UrlConstants_._OfficialWebsite);
#else
        UrlConstants_._OfficialWebsite;
#endif

    #endregion

    #region WattGame/商城

    /// <summary>
    /// 商城官网域名
    /// </summary>
    internal const string OfficialShopHostName = "shop.steampp.net";

    /// <summary>
    /// 商城 Api 域名
    /// </summary>
    internal const string OfficialShopApiHostName = "shop.api.steampp.net";

    /// <summary>
    /// 商城静态资源域名
    /// </summary>
    internal const string OfficialShopStaticHostName = "shop.static.steampp.net";

    internal const string OfficialShop_Ipv6Only_Development = $"{String2.Prefix_HTTPS}{OfficialHostName_Ipv6Only_Development}:7500";
    internal const string OfficialShop_MSTEST_Development = $"{String2.Prefix_HTTPS}{OfficialHostName_Development}";
    internal const string OfficialShop_Production = $"{String2.Prefix_HTTPS}{OfficialShopHostName}";

    internal const string OfficialShopApiBaseUrl_Ipv6Only_Development = $"{String2.Prefix_HTTPS}{OfficialShopApiHostName}";
    internal const string OfficialShopApiBaseUrl_MSTEST_Development = $"{String2.Prefix_HTTPS}{OfficialShopApiHostName}";
    internal const string OfficialShopApiBaseUrl_Production = $"{String2.Prefix_HTTPS}{OfficialShopApiHostName}";

    /// <summary>
    /// 商城官网网址
    /// </summary>
    public static string WattGame =>
#if PROJ_MOBIUS
        HostConstants_.V.WattGame.GetValueOrDefault(UrlConstants_._WattGame);
#else

        UrlConstants_._WattGame;
#endif

    /// <summary>
    /// 商城 Api 网址
    /// </summary>
    public static string WattGameApiBaseUrl =>
#if PROJ_MOBIUS
        HostConstants_.V.WattGameApiBaseUrl.GetValueOrDefault(UrlConstants_._WattGameApiBaseUrl);
#else
        UrlConstants_._WattGameApiBaseUrl;
#endif

    #endregion

#endif
}

static partial class UrlConstants_
{
    #region ApiBaseUrl/SppWebApi

    internal
#if PROJ_MOBIUS
        const
#else
        static
#endif
        string BaseUrl_API =
#if DEBUG || USE_DEV_API
#if USE_DEV_MSTEST
        BaseUrl_API_MSTEST_Development;
#else
        BaseUrl_API_Ipv6Only_Development;
#endif

#else
        BaseUrl_API_Production;

#endif

    /// <inheritdoc cref="UrlConstants.ApiBaseUrl"/>
    internal static string ApiBaseUrl
    {
        set
        {
            const bool httpsOnly =
#if DEBUG
                false;
#else
                true;
#endif
            if (String2.IsHttpUrl(value, httpsOnly))
            {
#if PROJ_MOBIUS
                HostConstants_.V.ApiBaseUrl = value;
#else
                BaseUrl_API = value;
#endif
            }
        }
    }

    #endregion

#if !PROJ_SETUP

    #region OfficialWebsite/官网

    internal
#if PROJ_MOBIUS
        const
#else
        static
#endif
        string _OfficialWebsite =
#if DEBUG || USE_DEV_API
#if USE_DEV_MSTEST
        OfficialWebsite_MSTEST_Development;
#else
        OfficialWebsite_Ipv6Only_Development;
#endif

#else
        OfficialWebsite_Production;

#endif

    /// <inheritdoc cref="UrlConstants.OfficialWebsite"/>
    internal static string OfficialWebsite
    {
        set
        {
            const bool httpsOnly =
#if DEBUG
                false;
#else
                true;
#endif
            if (String2.IsHttpUrl(value, httpsOnly))
            {
#if PROJ_MOBIUS
                HostConstants_.V.OfficialWebsite = value;
#else
                _OfficialWebsite = value;
#endif
            }
        }
    }

    #endregion

    #region WattGame/商城

    internal
#if PROJ_MOBIUS
        const
#else
        static
#endif
        string _WattGame =
#if DEBUG || USE_DEV_API
#if USE_DEV_MSTEST
        OfficialShop_MSTEST_Development;
#else
        OfficialShop_Ipv6Only_Development;
#endif

#else
        OfficialShop_Production;

#endif

    /// <inheritdoc cref="UrlConstants.WattGame"/>
    internal static string WattGame
    {
        set
        {
            const bool httpsOnly =
#if DEBUG
                false;
#else
                true;
#endif
            if (String2.IsHttpUrl(value, httpsOnly))
            {
#if PROJ_MOBIUS
                HostConstants_.V.WattGame = value;
#else
                _WattGame = value;
#endif
            }
        }
    }

    internal
#if PROJ_MOBIUS
        const
#else
        static
#endif
        string _WattGameApiBaseUrl =
#if DEBUG || USE_DEV_API
#if USE_DEV_MSTEST
        OfficialShopApiBaseUrl_MSTEST_Development;
#else
        OfficialShopApiBaseUrl_Ipv6Only_Development;
#endif

#else
        OfficialShopApiBaseUrl_Production;

#endif

    /// <inheritdoc cref="UrlConstants.WattGameApiBaseUrl"/>
    internal static string WattGameApiBaseUrl
    {
        set
        {
            const bool httpsOnly =
#if DEBUG
                false;
#else
                true;
#endif
            if (String2.IsHttpUrl(value, httpsOnly))
            {
#if PROJ_MOBIUS
                HostConstants_.V.WattGame = value;
#else
                _WattGame = value;
#endif
            }
        }
    }

    #endregion

#endif
}