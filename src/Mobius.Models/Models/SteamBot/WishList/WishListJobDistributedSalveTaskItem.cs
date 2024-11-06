namespace Mobius.Models.SteamBot.WishList;

[MPObj(true), MP2Obj(MP2SerializeLayout.Sequential)]
public partial struct WishListJobDistributedSalveTaskItem
{
    public Guid CommonTaskId { get; set; }

    public Guid GameId { get; set; }

    public bool UseUnLimitedUser { get; set; }

    public bool AddWishtList { get; set; }

    public bool AddFollowGame { get; set; }
}
