namespace Mobius.Models.Shop.Response;

/// <summary>
/// 获取购物车商品数量响应模型
/// </summary>
public class CartNumberAndMoneyResponse
{
    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("money")]
    public decimal Money { get; set; }
}