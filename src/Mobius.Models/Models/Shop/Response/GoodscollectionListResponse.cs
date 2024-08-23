namespace Mobius.Models.Shop.Response;

/// <summary>
/// 商品收藏关注列表响应模型
/// </summary>
public class GoodscollectionListResponse
{
    public IPageList<CoreCmsGoodsCollectionModel>? List { get; set; }

    public int Count { get; set; }
}
