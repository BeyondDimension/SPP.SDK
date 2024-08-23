namespace Mobius.Models.Shop.Response;

/// <summary>
/// 获取售后列表响应模型
/// </summary>
public class AftersalesListResponse
{
    [JsonPropertyName("list")]
    public List<CoreCmsBillAftersalesModel>? List { get; set; }

    [JsonPropertyName("page")]
    public int Page { get; set; }

    [JsonPropertyName("totalPage")]
    public int TotalPage { get; set; }

    [JsonPropertyName("hasNextPage")]
    public bool HasNextPage { get; set; }
}
