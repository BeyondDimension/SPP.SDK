namespace Mobius.Models.SteamBot.WishList;

[MPObj(true), MP2Obj(MP2SerializeLayout.Sequential)]
public partial record struct WishListJobDistributedMasterModel()
{
    /// <summary>
    /// Bot 是否限制账户
    /// </summary>
    public bool BotIsLimited { get; set; }

    /// <summary>
    /// Bot 是否获取失败
    /// </summary>
    public bool BotIsGetFailed { get; set; }

    public ImmutableArray<WishListJobDistributedMasterItem> Items { get; set; } = default;
}
