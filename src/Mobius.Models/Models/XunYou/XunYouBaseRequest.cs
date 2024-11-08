namespace Mobius.Models.XunYou;

/// <summary>
/// 迅游请求基类
/// </summary>
public abstract record class XunYouBaseRequest
{
    public virtual IReadOnlyDictionary<string, string> ToDictionary()
    {
        var dict = new SortedDictionary<string, string>();

        if (!string.IsNullOrEmpty(OpenId))
            dict.Add("open_id", OpenId);

        if (!string.IsNullOrEmpty(ChannelNo))
            dict.Add("channel_no", ChannelNo);

        if (!string.IsNullOrEmpty(ChannelType))
            dict.Add("channel_type", ChannelType);

        dict.Add("timestamp", Timestamp.ToString());

        if (!string.IsNullOrEmpty(SignType))
            dict.Add("sign_type", SignType);

        if (!string.IsNullOrEmpty(SignVersion))
            dict.Add("sign_ver", SignVersion);

        if (!string.IsNullOrEmpty(Brand))
            dict.Add("brand", Brand);

        return dict;
    }

    /// <summary>
    /// 用户账号
    /// </summary>
    [SystemTextJsonProperty("open_id")]
    public string? OpenId { get; set; }

    /// <summary>
    /// 渠道编号
    /// </summary>
    [SystemTextJsonProperty("channel_no")]
    public string? ChannelNo { get; set; } = "wattdistr";

    /// <summary>
    /// 渠道类型
    /// </summary>
    [SystemTextJsonProperty("channel_type")]
    public string? ChannelType { get; set; } = "thirdparty";

    /// <summary>
    /// 签名
    /// </summary>
    [SystemTextJsonProperty("sign")]
    public string? Sign { get; set; }

    /// <summary>
    /// 时间戳
    /// </summary>
    [SystemTextJsonProperty("timestamp")]
    public long Timestamp { get; set; } = DateTime.Now.ToUnixTimeSeconds();

    /// <summary>
    /// 签名类型
    /// </summary>
    [SystemTextJsonProperty("sign_type")]
    public string? SignType { get; set; } = "md5";

    /// <summary>
    /// 签名版本号
    /// </summary>
    [SystemTextJsonProperty("sign_ver")]
    public string? SignVersion { get; set; } = "1.0";

    /// <summary>
    /// 品牌
    /// </summary>
    [SystemTextJsonProperty("brand")]
    public string? Brand { get; set; } = "watt";
}
