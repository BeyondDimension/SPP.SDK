namespace Mobius.Models.Shop.Request;

public class AdvertRequest
{
    /// <summary>
    /// 广告位置编码
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// 广告位值类型
    /// </summary>
    public int Platform { get; set; } = 0;
}
