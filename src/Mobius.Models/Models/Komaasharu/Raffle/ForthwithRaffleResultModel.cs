namespace Mobius.Models.Komaasharu.Raffle;

public partial class ForthwithRaffleResultModel
{
    /// <summary>
    /// 主键
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// 奖品主键
    /// </summary>
    public Guid PrizeId { get; set; }

    /// <summary>
    /// 奖品名称
    /// </summary>
    public string PrizeName { get; set; } = string.Empty;

    /// <summary>
    /// 奖品内容
    /// </summary>
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// 中奖时间
    /// </summary>
    public DateTimeOffset? AwardReceivingTime { get; set; }
}