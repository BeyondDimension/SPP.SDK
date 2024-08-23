namespace Mobius.Models.Shop.Response;

/// <summary>
/// 广告位置响应模型类
/// </summary>
public class AdvertPositionResponse
{
    [JsonPropertyName("position")]
    public List<CoreCmsAdvertisementModel>? Position { get; set; }

    [JsonPropertyName("childs")]
    public List<CoreCmsAdvertPositionModel>? Childs { get; set; }
}
