namespace Mobius.Models;

/// <summary>
/// 商城推荐商品项
/// </summary>
sealed partial class ShopRecommendGoodItemModel
{
    /// <summary>
    /// 商品 Id
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 商品名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 价格
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// 封面
    /// </summary>
    public string Image { get; set; } = string.Empty;

    /// <summary>
    /// 商店原价
    /// </summary>
    public decimal Mktprice { get; set; }

    /// <summary>
    /// 简介
    /// </summary>
    public string Brief { get; set; } = string.Empty;

    /// <summary>
    /// 商品分类 ,分割 : 分割 id:name
    /// </summary>
    public string GoodsAllCategorys { get; set; } = string.Empty;

    public ShopUsePlatform UsePlatform { get; set; } = ShopUsePlatform.Steam;
}

#if DEBUG
public partial class ShopRecommendGoodItemModel { }
#endif
