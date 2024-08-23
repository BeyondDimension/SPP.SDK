namespace Mobius.Models.Shop.Response;

/// <summary>
/// 商城用户信息响应模型
/// </summary>
public class UserInfoResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("userName")]
    public string UserName { get; set; } = string.Empty;

    [JsonPropertyName("mobile")]
    public string Mobile { get; set; } = string.Empty;

    [JsonPropertyName("sex")]
    public int Sex { get; set; }

    [JsonPropertyName("birthay")]
    public DateTime? Birthday { get; set; }

    [JsonPropertyName("avatarImage")]
    public string AvatarImage { get; set; } = string.Empty;

    [JsonPropertyName("nickName")]
    public string NickName { get; set; } = string.Empty;

    [JsonPropertyName("balance")]
    public decimal Balance { get; set; }

    [JsonPropertyName("point")]
    public int Point { get; set; }

    [JsonPropertyName("grade")]
    public int Grade { get; set; }

    [JsonPropertyName("createTime")]
    public DateTime CreateTime { get; set; }

    [JsonPropertyName("updateTime")]
    public DateTime? UpdateTime { get; set; }

    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("parentId")]
    public int ParentId { get; set; }

    [JsonPropertyName("password")]
    public string Password { get; set; } = string.Empty;

    [JsonPropertyName("gradeName")]
    public string GradeName { get; set; } = string.Empty;

    [JsonPropertyName("userCouponCount")]
    public int UserCouponCount { get; set; }

    [JsonPropertyName("orderCount")]
    public int OrderCount { get; set; }

    [JsonPropertyName("footPrintCount")]
    public int FootPrintCount { get; set; }

    [JsonPropertyName("collectionCount")]
    public int CollectionCount { get; set; }
}
