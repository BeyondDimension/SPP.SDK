namespace Mobius.Models.SteamBot.WishList;

[MPObj(true), MP2Obj(MP2SerializeLayout.Sequential)]
public partial record struct WishListJobDistributedMasterItem
{
    public Guid CommonTaskId { get; set; }

    public Guid GameId { get; set; }

    public bool AddWishtListSuccess { get; set; }

    public bool AddFollowGameSuccess { get; set; }
}
