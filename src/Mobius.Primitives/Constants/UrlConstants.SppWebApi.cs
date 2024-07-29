namespace Mobius.Constants;

partial class UrlConstants // SppWebApi
{
    /// <summary>
    /// 根据广告 Id 获取跳转地址
    /// </summary>
    /// <param name="komaasharuId"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static FormattableString GetAdvertisementJumpUrl(Guid komaasharuId)
        => $"{ApiBaseUrl}/komaasharu/{komaasharuId}";

    /// <summary>
    /// 根据广告 Id 获取图片地址
    /// </summary>
    /// <param name="komaasharuId"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static FormattableString GetAdvertisementImageUrl(Guid komaasharuId)
        => $"{ApiBaseUrl}/komaasharu/images/{komaasharuId}";
}
