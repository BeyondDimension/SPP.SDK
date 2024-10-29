namespace Mobius.Models.Komaasharu.Raffle;

[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
public partial class RaffleRegistrationUserModel
{
    [MPKey(0), MP2Key(0)]
    public Guid Id { get; set; }

    [MPKey(1), MP2Key(1)]
    public Guid ActivityId { get; set; }

    [MPKey(2), MP2Key(2)]
    public Guid UserId { get; set; }

    [MPKey(3), MP2Key(3)]
    public DateTimeOffset ParticipationTime { get; set; }

    [MPKey(4), MP2Key(4)]
    public RaffleActivityModel? Activity { get; set; }

    [MPKey(5), MP2Key(5)]
    public string? UserNickName { get; set; }
}
