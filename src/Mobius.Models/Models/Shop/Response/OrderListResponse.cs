namespace Mobius.Models.Shop.Response;

/// <summary>
/// 订单列表响应模型
/// </summary>
public class OrderListResponse
{
    [JsonPropertyName("list")]
    public IPageList<CoreCmsOrderModel>? List { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("page")]
    public int Page { get; set; }

    [JsonPropertyName("limit")]
    public int Limit { get; set; }

    [JsonPropertyName("IsOpenSelfDelivery")]
    public int Status { get; set; }
}