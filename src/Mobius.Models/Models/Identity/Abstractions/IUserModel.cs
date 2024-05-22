namespace Mobius.Models.Identity.Abstractions;

/// <summary>
/// 用户模型
/// </summary>
public interface IUserModel
{
    /// <summary>
    /// 昵称最大长度
    /// </summary>
    const int MaxLength_NickName = LengthConstants.Max_CUserNickName;

    /// <summary>
    /// 用户 Id
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// 昵称
    /// </summary>
    string NickName { get; set; }

    /// <summary>
    /// 头像
    /// </summary>
    Guid Avatar { get; set; }

    /// <inheritdoc cref="DebuggerDisplayAttribute"/>
    protected static string GetDebuggerDisplay(IUserModel user)
        => $"{user.NickName}: {user.Id}";
}