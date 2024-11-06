namespace Mobius.Models.SteamBot.WishList;

[MPObj(true), MP2Obj(MP2SerializeLayout.Sequential)]
public partial struct WishListJobDistributedSalveModel()
{
    public BotConfigModel BotConfig { get; set; }

    public TimeSpan WaitSpan { get; set; }

    public ImmutableArray<WishListJobDistributedSalveTaskItem> Items { get; set; } = default;
}
