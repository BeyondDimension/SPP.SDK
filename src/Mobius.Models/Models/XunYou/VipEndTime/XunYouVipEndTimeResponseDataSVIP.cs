namespace Mobius.Models.XunYou.VipEndTime;

[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial record class XunYouVipEndTimeResponseDataSVIP
{
    /// <summary>
    /// SVIP 到期时间
    /// </summary>
    [SystemTextJsonProperty("etime")]
    [MPKey(0), MP2Key(0)]
    public long ETime { get; set; }

    [SystemTextJsonProperty("expire_time")]
    [MPKey(1), MP2Key(1)]
    public long ExpireTime { get; set; }

    [SystemTextJsonProperty("gift_begin_time")]
    [MPKey(2), MP2Key(2)]
    public long GiftBeginTime { get; set; }

    [SystemTextJsonProperty("rtime")]
    [MPKey(3), MP2Key(3)]
    public long RTime { get; set; }

    [SystemTextJsonProperty("service_type")]
    [MPKey(4), MP2Key(4)]
    public string? ServiceType { get; set; }
}
