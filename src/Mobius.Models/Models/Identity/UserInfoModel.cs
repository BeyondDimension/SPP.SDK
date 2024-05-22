namespace Mobius.Models.Identity;

/// <summary>
/// 用户信息模型
/// </summary>
[MPObj, MP2Obj(GenerateType.VersionTolerant, MP2SerializeLayout.Explicit)]
sealed partial record class UserInfoModel : IBirthDateTimeZone, IPhoneNumber, IUserModel
{
    /// <summary>
    /// 用户 Id
    /// </summary>
    [MPKey(0), MP2Key(0)]
    public Guid Id { get; set; }

    /// <summary>
    /// 昵称
    /// </summary>
    [MPKey(1), MP2Key(1)]
    public string NickName { get; set; } = string.Empty;

    /// <summary>
    /// 头像
    /// </summary>
    [MPKey(2), MP2Key(2)]
    public Guid Avatar { get; set; }

    /// <summary>
    /// 经验值
    /// </summary>
    [MPKey(3), MP2Key(3)]
    public uint Experience { get; set; }

    /// <summary>
    /// 余额
    /// </summary>
    [MPKey(4), MP2Key(4)]
    public decimal Balance { get; set; }

    /// <summary>
    /// 账号等级
    /// </summary>
    [MPKey(5), MP2Key(5)]
    public byte Level { get; set; }

    /// <summary>
    /// 关联 Steam 账号 64 位 Id
    /// </summary>
    [MPKey(6), MP2Key(6)]
    public long? SteamAccountId { get; set; }

    /// <summary>
    /// 性别
    /// </summary>
    [MPKey(7), MP2Key(7)]
    public Gender Gender { get; set; }

    /// <inheritdoc/>
    [MPKey(8), MP2Key(8)]
    public DateTime? BirthDate { get; set; }

    /// <inheritdoc/>
    [MPKey(9), MP2Key(9)]
    public sbyte BirthDateTimeZone { get; set; }

    /// <summary>
    /// 根据出生日期计算出的年龄
    /// </summary>
    [MPKey(10), MP2Key(10)]
    public byte? CalcAge { get; set; }

    /// <summary>
    /// 年龄
    /// </summary>
    [XmlIgnore, IgnoreDataMember, SystemTextJsonIgnore, NewtonsoftJsonIgnore, MPIgnore, MP2Ignore]
    public string Age
    {
        get
        {
            byte value;
            if (CalcAge.HasValue) value = CalcAge.Value;
            else value = BirthDateHelper.CalcAge(this.GetBirthDate()?.DateTime);
            return BirthDateHelper.ToString(value);
        }
    }

    /// <summary>
    /// 所在地
    /// </summary>
    [MPKey(11), MP2Key(11)]
    public int? AreaId { get; set; }

    /// <summary>
    /// 微软账号邮箱
    /// </summary>
    [MPKey(12), MP2Key(12)]
    public string? MicrosoftAccountEmail { get; set; }

    /// <summary>
    /// 苹果账号邮箱
    /// </summary>
    [MPKey(13), MP2Key(13)]
    public string? AppleAccountEmail { get; set; }

    /// <summary>
    /// QQ 昵称
    /// </summary>
    [MPKey(14), MP2Key(14)]
    public string? QQNickName { get; set; }

    /// <summary>
    /// 通过快速登录获取的头像 Url
    /// </summary>
    [MPKey(15), MP2Key(15)]
    public Dictionary<ExternalLoginChannel, string>? AvatarUrl { get; set; }

    /// <summary>
    /// 用户类型
    /// </summary>
    [MPKey(16), MP2Key(16)]
    public UserType UserType { get; set; }

    /// <summary>
    /// 下级所需经验
    /// </summary>
    [MPKey(17), MP2Key(17)]
    public uint NextExperience { get; set; }

    /// <summary>
    /// 是否签到
    /// </summary>
    [MPKey(18), MP2Key(18)]
    public bool IsSignIn { get; set; }

    /// <inheritdoc/>
    [MPKey(19), MP2Key(19)]
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// 个性签名
    /// </summary>
    [MPKey(20), MP2Key(20)]
    public string? PersonalizedSignature { get; set; }

    /// <summary>
    /// 加速器 OpenId
    /// </summary>
    [MPKey(21), MP2Key(21)]
    public string? WattOpenId { get; set; }

    /// <inheritdoc/>
    public override string ToString() => $"NickName: {NickName}, Id: {Id}";
}
