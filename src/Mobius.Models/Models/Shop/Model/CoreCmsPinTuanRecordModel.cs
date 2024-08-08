namespace Mobius.Models.Shop;

/// <summary>
/// 拼团记录表
/// </summary>
public partial class CoreCmsPinTuanRecordModel
{
    /// <summary>
    /// 构造函数
    /// </summary>
    public CoreCmsPinTuanRecord()
    {
    }

    /// <summary>
    /// 序列
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// 团序列
    /// </summary>
    [JsonPropertyName("teamId")]
    public int TeamId { get; set; }

    /// <summary>
    /// 用户序列
    /// </summary>
    [JsonPropertyName("userId")]
    public int UserId { get; set; }

    /// <summary>
    /// 规则表序列
    /// </summary>
    [JsonPropertyName("ruleId")]
    public int RuleId { get; set; }

    /// <summary>
    /// 商品序列
    /// </summary>
    [JsonPropertyName("goodsId")]
    public int GoodsId { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }

    /// <summary>
    /// 订单序列
    /// </summary>
    [JsonPropertyName("orderId")]
    public string OrderId { get; set; } = string.Empty;

    /// <summary>
    /// 拼团人数Json
    /// </summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }

    /// <summary>
    /// 关闭时间
    /// </summary>
    [JsonPropertyName("closeTime")]
    public DateTime CloseTime { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    [JsonPropertyName("createTime")]
    public DateTime CreateTime { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    [JsonPropertyName("updateTime")]
    public DateTime? UpdateTime { get; set; }
}

/// <summary>
/// 拼团记录
/// </summary>
public partial class CoreCmsPinTuanRecordModel
{
    /// <summary>
    /// 用户头像
    /// </summary>
    [JsonPropertyName("userAvatar")]
    public string UserAvatar { get; set; } = string.Empty;

    /// <summary>
    /// 昵称
    /// </summary>
    [JsonPropertyName("nickName")]
    public string NickName { get; set; } = string.Empty;

    /// <summary>
    /// 参与队员信息
    /// </summary>
    [JsonPropertyName("teams")]
    public List<PinTuanRecordTeamModel> Teams { get; set; } = new List<PinTuanRecordTeamModel>();

    /// <summary>
    /// 参与数量
    /// </summary>
    [JsonPropertyName("teamNums")]
    public int TeamNums { get; set; }

    /// <summary>
    /// 参与人数计算
    /// </summary>
    [JsonPropertyName("peopleNumber")]
    public int PeopleNumber { get; set; } = 0;

    /// <summary>
    /// 剩余时间
    /// </summary>
    [JsonPropertyName("lastTime")]
    public int LastTime { get; set; }

    /// <summary>
    /// 是否过期
    /// </summary>
    [JsonPropertyName("isOverdue")]
    public bool IsOverdue { get; set; } = false;

    /// <summary>
    /// 活动名称
    /// </summary>
    [JsonPropertyName("ruleName")]
    public string RuleName { get; set; } = string.Empty;

    /// <summary>
    /// 商品名称
    /// </summary>
    [JsonPropertyName("goodName")]
    public string GoodName { get; set; } = string.Empty;
}

public class PinTuanRecordTeamModel
{
    /// <summary>
    /// 用户头像
    /// </summary>
    [JsonPropertyName("userAvatar")]
    public string UserAvatar { get; set; } = string.Empty;

    /// <summary>
    /// 昵称
    /// </summary>
    [JsonPropertyName("nickName")]
    public string NickName { get; set; } = string.Empty;

    /// <summary>
    /// 记录编号
    /// </summary>
    [JsonPropertyName("recordId")]
    public int RecordId { get; set; } = 0;

    /// <summary>
    /// 拼团队伍编号
    /// </summary>
    [JsonPropertyName("teamId")]
    public int TeamId { get; set; } = 0;

    /// <summary>
    /// 用户编号
    /// </summary>
    [JsonPropertyName("userId")]
    public int UserId { get; set; } = 0;
}