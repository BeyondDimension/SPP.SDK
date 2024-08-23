namespace Mobius.Models.Shop.Response;

/// <summary>
/// 获取不同类型营销下单支持的配送方式响应模型
/// </summary>
public class OrderDistributionResponse
{
    [JsonPropertyName("isOpenMailing")]
    public bool IsOpenMailing { get; set; }

    [JsonPropertyName("isOpenHomeDelivery")]
    public bool IsOpenHomeDelivery { get; set; }

    [JsonPropertyName("IsOpenSelfDelivery")]
    public bool IsOpenSelfDelivery { get; set; }

    [JsonPropertyName("isOpenVirtual")]
    public bool IsOpenVirtual { get; set; }
}
