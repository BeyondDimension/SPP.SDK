namespace Mobius.Models.Shop.Request;

/// <summary>
/// 用户手动提取CDkey
/// </summary>
public class UserCDKeyExtractRequest
{
    [SystemTextJsonProperty("orderId")]
    public string OrderId { get; set; } = string.Empty;

    [SystemTextJsonProperty("orderItemId")]
    public int OrderItemId { get; set; }
}