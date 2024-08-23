namespace Mobius.Models.Shop.Request;

/// <summary>
///  提交售后单参数
/// </summary>
public class AddBillAfterSalesPostRequest
{
    /// <summary>
    /// 订单编号
    /// </summary>
    [JsonPropertyName("orderId")]
    public string OrderId { get; set; } = string.Empty;

    /// <summary>
    /// 是否收到退货，1未收到退货，不会创建退货单，2收到退货，会创建退货单，只有未发货的商品才能选择未收到货，只有已发货的才能选择已收到货
    /// </summary>
    [JsonPropertyName("type")]
    public int Type { get; set; } = 0;

    /// <summary>
    /// 如果是退款退货，退货的明细以 [[order_item_id=>nums]] 的二维数组形式传值
    /// </summary>
    [JsonPropertyName("items")]
    public JArray? Items { get; set; }

    /// <summary>
    /// 上传图集
    /// </summary>
    [JsonPropertyName("images")]
    public string[]? Images { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; } = string.Empty;

    /// <summary>
    /// 金额
    /// </summary>
    [JsonPropertyName("refund")]
    public decimal Refund { get; set; } = 0;
}
