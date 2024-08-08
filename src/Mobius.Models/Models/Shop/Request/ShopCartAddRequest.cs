namespace Mobius.Models.Shop.Request;

/// <summary>
/// 商城添加购物车
/// </summary>
public class ShopCartAddRequest
{
    /// <summary>
    /// 单品数量
    /// </summary>
    public int Nums { get; set; } = 0;

    /// <summary>
    /// 货品序号 商品选中 SkuId productDetail.chooseSku.Id
    /// </summary>
    public int ProductId { get; set; } = 0;

    /// <summary>
    /// 数量类型 1是直接增加，2是赋值
    /// </summary>
    [SystemTextJsonProperty("type")]
    public int Type { get; set; } = 1;

    /// <summary>
    /// 目前购物车类型 1是普通货品，2 是拼团 3是团购 目前只支持 1 普通商品
    /// </summary>
    [SystemTextJsonProperty("cartType")]
    public int CartType { get; set; } = 1;

    /// <summary>
    /// 非普通货品，关联对象序列 使用 商品信息的 groupId
    /// </summary>
    [SystemTextJsonProperty("objectId")]
    public int ObjectId { get; set; } = 0;
}
