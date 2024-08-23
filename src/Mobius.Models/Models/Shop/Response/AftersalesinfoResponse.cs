namespace Mobius.Models.Shop.Response;

/// <summary>
/// 售后单详情响应模型
/// </summary>
public class AftersalesinfoResponse
{
    [JsonPropertyName("info")]
    public List<CoreCmsBillAftersalesModel>? Info { get; set; }

    [JsonPropertyName("reship")]
    public Reship? Reship { get; set; }
}

public class Reship
{
    [JsonPropertyName("reshipAddress")]
    public string ReshipAddress { get; set; } = string.Empty;

    [JsonPropertyName("reshipArea")]
    public string ReshipArea { get; set; } = string.Empty;

    [JsonPropertyName("reshipMobile")]
    public string ReshipMobile { get; set; } = string.Empty;

    [JsonPropertyName("reshipName")]
    public string ReshipName { get; set; } = string.Empty;
}
