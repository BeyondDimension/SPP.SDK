namespace Mobius.Models.Shop.Request;

/// <summary>
///  设置购物车商品数量
/// </summary>
public class SetCartNumRequest
{
    [SystemTextJsonProperty("id")]
    public int Id { get; set; } = 0;

    [SystemTextJsonProperty("nums")]
    public int Nums { get; set; } = 1;
}
