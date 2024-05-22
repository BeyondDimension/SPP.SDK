namespace Mobius.Constants;

partial class UrlConstants // SppWebApi
{
    /// <summary>
    /// 根据广告 Id 获取跳转地址
    /// </summary>
    /// <param name="komaasharuId"></param>
    /// <returns></returns>
    public static string GetAdvertisementJumpUrl(Guid komaasharuId)
        => $"{BaseUrl_API}/komaasharu/{komaasharuId}";

    /// <summary>
    /// 根据广告 Id 获取图片地址
    /// </summary>
    /// <param name="komaasharuId"></param>
    /// <returns></returns>
    public static string GetAdvertisementImageUrl(Guid komaasharuId)
        => $"{BaseUrl_API}/komaasharu/images/{komaasharuId}";
}
