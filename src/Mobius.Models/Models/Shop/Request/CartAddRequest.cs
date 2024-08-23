namespace Mobius.Models.Shop.Request;

/// <summary>
/// 单个货品接入购物车
/// </summary>
public class CartAddRequest
{
    /// <summary>
    /// 单品数量
    /// </summary>
    public int Nums { get; set; } = 0;

    /// <summary>
    /// 货品序号
    /// </summary>
    public int ProductId { get; set; } = 0;

    /// <summary>
    /// 数量类型 1是直接增加，2是赋值
    /// </summary>
    [SystemTextJsonProperty("type")]
    public int Type { get; set; } = 1;

    /// <summary>
    /// 普通购物还是团购秒杀/关联CartTypes
    /// </summary>
    [SystemTextJsonProperty("cartType")]
    public int CartType { get; set; } = 1;

    /// <summary>
    /// 非普通货品，关联对象序列
    /// </summary>
    [SystemTextJsonProperty("objectId")]
    public int ObjectId { get; set; } = 0;
}