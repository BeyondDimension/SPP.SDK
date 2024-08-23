namespace Mobius.Models.Shop;

public partial class CoreCmsUserModel
{
    /// <summary>
    /// 用户ID
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// 用户名
    /// </summary>
    [JsonPropertyName("userName")]
    public string UserName { get; set; } = string.Empty;

    /// <summary>
    /// 密码
    /// </summary>
    [JsonPropertyName("passWord")]
    public string Password { get; set; } = string.Empty;

    /// <summary>
    /// 手机号
    /// </summary>
    [JsonPropertyName("mobile")]
    public string Mobile { get; set; } = string.Empty;

    /// <summary>
    /// 性别[1男2女3未知]
    /// </summary>
    [JsonPropertyName("sex")]
    public int Sex { get; set; }

    /// <summary>
    /// 生日
    /// </summary>
    [JsonPropertyName("birthday")]
    public DateTime? Birthday { get; set; }

    /// <summary>
    /// 头像
    /// </summary>
    [JsonPropertyName("avatarImage")]
    public string AvatarImage { get; set; } = string.Empty;

    /// <summary>
    /// 昵称
    /// </summary>
    [JsonPropertyName("nickName")]
    public string NickName { get; set; } = string.Empty;

    /// <summary>
    /// 余额
    /// </summary>
    [JsonPropertyName("balance")]
    public decimal Balance { get; set; }

    /// <summary>
    /// 积分
    /// </summary>
    [JsonPropertyName("point")]
    public int Point { get; set; }

    /// <summary>
    /// 用户等级
    /// </summary>
    [JsonPropertyName("grade")]
    public int Grade { get; set; }

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

    /// <summary>
    /// 状态[1正常2停用]
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }

    /// <summary>
    /// 推荐人
    /// </summary>
    [JsonPropertyName("parentId")]
    public int ParentId { get; set; }

    /// <summary>
    /// 关联三方账户
    /// </summary>
    [JsonPropertyName("userWx")]
    public int UserWx { get; set; }

    /// <summary>
    /// 删除标志 有数据就是删除
    /// </summary>
    [JsonPropertyName("isDelete")]
    public bool IsDelete { get; set; }

    /// <summary>
    /// AuthId
    /// </summary>
    [JsonPropertyName("authorizationId")]
    public string AuthorizationId { get; set; } = string.Empty;

    /// <summary>
    /// 电子邮箱
    /// </summary>
    [JsonPropertyName("email")]
    public string Email { get; set; } = string.Empty;
}

public partial class CoreCmsUserModel
{
    /// <summary>
    /// 来源类型
    /// </summary>
    [JsonPropertyName("type")]
    public int Type { get; set; }

    /// <summary>
    /// 下级用户数量
    /// </summary>
    [JsonPropertyName("childNum")]
    public int ChildNum { get; set; }

    /// <summary>
    /// 父级名称
    /// </summary>
    [JsonPropertyName("parentNickName")]
    public string ParentNickName { get; set; } = string.Empty;

    /// <summary>
    /// 累计积分
    /// </summary>
    [JsonPropertyName("accumulativePoint")]
    public int AccumulativePoint { get; set; }
}