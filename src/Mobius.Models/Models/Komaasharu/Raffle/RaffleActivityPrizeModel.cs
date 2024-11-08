namespace Mobius.Models.Komaasharu.Raffle;

[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
public partial class RaffleActivityPrizeModel
{
    [MPKey(0), MP2Key(0)]
    public Guid Id { get; set; }

    [MPKey(1), MP2Key(1)]
    public string Name { get; set; } = string.Empty;

    [MPKey(2), MP2Key(2)]
    public byte PrizeLevel { get; set; }

    [MPKey(3), MP2Key(3)]
    public string? Describe { get; set; }

    [MPKey(4), MP2Key(4)]
    public string? PrizeImg { get; set; }

    [MPKey(5), MP2Key(5)]
    public int PrizeNumber { get; set; }

    [MPKey(6), MP2Key(6)]
    public decimal? PriceIndication { get; set; }
}
