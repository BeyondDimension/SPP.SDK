namespace Mobius.Models.Shop.Response;

/// <summary>
/// 商品列表响应模型
/// </summary>
public class GoodsPageResponse
{
    [JsonPropertyName("list")]
    public IPageList<GoodListModel>? List { get; set; }

    [JsonPropertyName("className")]
    public string ClassName { get; set; } = string.Empty;

    [JsonPropertyName("page")]
    public int Page { get; set; }

    public int TotalCount { get; set; }

    public int TotalPages { get; set; }

    [JsonPropertyName("limit")]
    public int Limit { get; set; }

    [JsonPropertyName("where")]
    public string Where { get; set; } = string.Empty;

    [JsonPropertyName("order")]
    public string Order { get; set; } = string.Empty;
}
