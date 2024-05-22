namespace Mobius.Enums.Shop;

/// <summary>
/// 商城定义的平台
/// </summary>
public enum ShopUsePlatform
{
    /// <summary>
    /// Steam
    /// </summary>
    [Description("Steam")]
    Steam = 1,

    /// <summary>
    /// Microsoft
    /// </summary>
    [Description("Microsoft")]
    Microsoft = 5,

    /// <summary>
    /// BattleNet
    /// </summary>
    [Description("BattleNet")]
    BattleNet = 11,

    /// <summary>
    /// Google
    /// </summary>
    [Description("Google")]
    Google = 12,

    /// <summary>
    /// HOTP
    /// </summary>
    [Description("HOTP")]
    HOTP = 13,
}