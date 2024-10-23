namespace Mobius.Enums.SteamBot;

/// <summary>
/// SteamBot 点数打赏 打赏状态
/// </summary>
public enum RewardStatus : byte
{
    /// <summary>
    /// 等待支付
    /// </summary>
    Waiting,

    /// <summary>
    /// 进行中
    /// </summary>
    InProgress,

    /// <summary>
    /// 完成
    /// </summary>
    Completed,

    /// <summary>
    /// 异常
    /// </summary>
    Exception,

    /// <summary>
    /// 停止
    /// </summary>
    Closed
}
