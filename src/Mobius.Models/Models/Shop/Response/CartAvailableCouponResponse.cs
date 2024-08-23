namespace Mobius.Models.Shop.Response;

/// <summary>
/// 获取可使用购物券响应模型
/// </summary>
public class CartAvailableCouponResponse
{
    [JsonPropertyName("list")]
    public List<MyCouponResultModel>? List { get; set; }

    [JsonPropertyName("changeData")]
    public List<CoreCmsCouponModel>? ChangeData { get; set; }

    [JsonPropertyName("cartProducts")]
    public List<CartProductsModel>? CartProducts { get; set; }

    [JsonPropertyName("user")]
    public List<CoreCmsUserModel>? User { get; set; }
}
