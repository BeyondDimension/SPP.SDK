namespace Mobius.Enums.Identity;

/// <summary>
/// 用户类型
/// </summary>
[Flags]
public enum UserType : long
{
    /// <summary>
    /// 普通用户
    /// </summary>
    Ordinary = 1,

    /// <summary>
    /// 赞助用户
    /// </summary>
    Sponsor = 2,
}