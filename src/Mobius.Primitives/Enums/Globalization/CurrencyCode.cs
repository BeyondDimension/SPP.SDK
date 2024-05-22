namespace Mobius.Enums.Globalization;

/// <summary>
/// 货币 (steampp.net 平台)
/// </summary>
public enum CurrencyCode : byte
{
    /// <summary>
    /// ¥ 人民币
    /// </summary>
    CNY = 1,

    /// <summary>
    /// $ 美元
    /// </summary>
    USD = 2,

    GBP = 23,
    EUR = 3,
    CHF = 4,
    RUB = 5,
    PLN = 6,
    BRL = 7,
    JPY = 8,
    NOK = 9,
    IDR = 10,
    MYR = 11,
    PHP = 12,
    SGD = 13,
    THB = 14,
    VND = 0xF,
    KRW = 0x10,

    /// <summary>
    /// 土耳其里拉
    /// </summary>
    TRY = 17,
    UAH = 18,
    MXN = 19,
    CAD = 20,
    AUD = 21,
    NZD = 22,
    INR = 24,
    CLP = 25,
    PEN = 26,
    COP = 27,
    ZAR = 28,
    HKD = 29,
    TWD = 30,
    SAR = 0x1F,
    AED = 0x20,

    /// <summary>
    /// 阿根廷比索
    /// </summary>
    ARS = 34,
    ILS = 35,
    BYN = 36,
    KZT = 37,
    KWD = 38,
    QAR = 39,
    CRC = 40,
    UYU = 41,
}

/// <summary>
/// Enum 扩展 <see cref="CurrencyCode"/>
/// </summary>
public static class CurrencyCodeEnumExtensions
{
    /// <summary>
    /// 将货币转换为中文名称
    /// </summary>
    /// <param name="currencyCode"></param>
    /// <returns></returns>
    public static string ToChineseString(this CurrencyCode currencyCode) => currencyCode switch
    {
        CurrencyCode.AED => "阿联酋迪拉姆",
        CurrencyCode.ARS => "阿根廷比索",
        CurrencyCode.AUD => "澳元",
        CurrencyCode.BRL => "巴西雷亚尔",
        CurrencyCode.CAD => "加元",
        CurrencyCode.CHF => "瑞士法郎",
        CurrencyCode.CLP => "智利比索",
        CurrencyCode.CNY => "人民币",
        CurrencyCode.COP => "哥伦比亚比索",
        CurrencyCode.CRC => "哥斯达尼家科朗",
        CurrencyCode.EUR => "欧元",
        CurrencyCode.GBP => "英镑",
        CurrencyCode.HKD => "港元",
        CurrencyCode.IDR => "卢比",
        CurrencyCode.ILS => "新谢克尔",
        CurrencyCode.INR => "印度卢比",
        CurrencyCode.JPY => "日元",
        CurrencyCode.KRW => "韩元",
        CurrencyCode.KWD => "科威特第纳尔",
        CurrencyCode.KZT => "腾格",
        CurrencyCode.MXN => "墨西哥比索",
        CurrencyCode.MYR => "马来西亚林吉特",
        CurrencyCode.NOK => "挪威克朗",
        CurrencyCode.NZD => "新西兰",
        CurrencyCode.PEN => "新索尔",
        CurrencyCode.PHP => "菲律宾比索",
        CurrencyCode.PLN => "兹罗提",
        CurrencyCode.QAR => "卡塔尔里亚尔",
        CurrencyCode.RUB => "俄罗斯卢布",
        CurrencyCode.SAR => "沙特里亚尔",
        CurrencyCode.SGD => "新加坡",
        CurrencyCode.THB => "泰铢",
        CurrencyCode.TRY => "土耳其里拉",
        CurrencyCode.TWD => "新台币",
        CurrencyCode.UAH => "格里夫尼亚",
        CurrencyCode.USD => "美元",
        CurrencyCode.UYU => "乌拉圭比索",
        CurrencyCode.VND => "越南盾",
        CurrencyCode.ZAR => "兰特",
        CurrencyCode.BYN => "白俄罗斯卢布",

        _ => currencyCode.ToString(),
    };

    /// <summary>
    /// 将货币转换为用于显示的字符串
    /// </summary>
    /// <param name="currencyCode"></param>
    /// <returns></returns>
    public static string ToDisplayString(this CurrencyCode currencyCode)
    {
        var currencyCodeStr = currencyCode.ToString();
        var currencyCodeCNStr = currencyCode.ToChineseString();
        if (currencyCodeStr == currencyCodeCNStr) return currencyCodeStr;
        return $"{currencyCodeCNStr} {currencyCodeStr}";
    }

    /// <summary>
    /// 将货币转换为 Steam 地区/国家
    /// </summary>
    /// <param name="currencyCode"></param>
    /// <returns></returns>
    public static string? ToSteamCountry(this CurrencyCode currencyCode) => currencyCode switch
    {
        CurrencyCode.ARS => "阿根廷",
        CurrencyCode.TRY => "土耳其",
        CurrencyCode.BRL => "巴西",
        CurrencyCode.CNY => "中国",
        CurrencyCode.JPY => "日本",
        CurrencyCode.GBP => "美国",
        CurrencyCode.HKD => "香港",
        CurrencyCode.RUB => "俄罗斯联邦",
        CurrencyCode.INR => "印度",
        _ => null,
    };

    /// <summary>
    /// 将货币转换为 Steam CCCode
    /// </summary>
    /// <param name="currencyCode"></param>
    /// <returns></returns>
    public static string? ToSteamCCCode(this CurrencyCode currencyCode) => currencyCode switch
    {
        CurrencyCode.ARS => "AR",
        CurrencyCode.TRY => "TR",
        CurrencyCode.BRL => "BR",
        CurrencyCode.CNY => "CN",
        CurrencyCode.JPY => "JP",
        CurrencyCode.GBP => "US",
        CurrencyCode.HKD => "HK",
        CurrencyCode.RUB => "RU",
        CurrencyCode.INR => "IN",
        CurrencyCode.USD => "US",
        _ => null,
    };

    /// <summary>
    /// 将货币从 (steampp.net 平台) 转换为 (Steam 平台)
    /// </summary>
    /// <param name="currencyCode"></param>
    /// <returns></returns>
    public static SteamCurrencyCode ToSteamCurrencyCode(this CurrencyCode currencyCode) => currencyCode switch
    {
        CurrencyCode.USD => SteamCurrencyCode.USD,
        CurrencyCode.CNY => SteamCurrencyCode.CNY,
        CurrencyCode.GBP => SteamCurrencyCode.GBP,
        _ => (SteamCurrencyCode)currencyCode,
    };

    /// <summary>
    /// 将货币从 (Steam 平台) 转换为 (steampp.net 平台)
    /// </summary>
    /// <param name="currencyCode"></param>
    /// <returns></returns>
    public static CurrencyCode ToCurrencyCode(this SteamCurrencyCode currencyCode) => currencyCode switch
    {
        SteamCurrencyCode.USD => CurrencyCode.USD,
        SteamCurrencyCode.CNY => CurrencyCode.CNY,
        SteamCurrencyCode.GBP => CurrencyCode.GBP,
        _ => (CurrencyCode)currencyCode,
    };

    /// <summary>
    /// 根据货币获取区域信息
    /// </summary>
    /// <param name="eCurrencyCode"></param>
    /// <returns></returns>
    public static CultureInfo? GetCultureInfo(this CurrencyCode eCurrencyCode)
           => CultureInfo.GetCultures(CultureTypes.SpecificCultures)
           .FirstOrDefault(culture => new RegionInfo(culture.Name).ISOCurrencySymbol == eCurrencyCode.ToString());
}