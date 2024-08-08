namespace Mobius.Models.Shop;

public partial class CoreCmsGoodsGradeModel
{
    /// <summary>
    /// 商品会员价表
    /// </summary>
    public CoreCmsGoodsGradeModel()
    {
    }

    /// <summary>
    /// 序列
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// 商品id
    /// </summary>
    [JsonPropertyName("goodsId")]
    public int GoodsId { get; set; }

    /// <summary>
    /// 会员等级id
    /// </summary>
    [JsonPropertyName("gradeId")]
    public int GradeId { get; set; }

    /// <summary>
    /// 会员价
    /// </summary>
    [JsonPropertyName("gradePrice")]
    public decimal GradePrice { get; set; }
}