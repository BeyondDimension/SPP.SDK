namespace Mobius.Models.XunYou.VipEndTime;

[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial record class XunYouVipEndTimeResponseData
{
    [MPKey(0), MP2Key(0)]
    [SystemTextJsonProperty("server_time")]
    public long ServerTime { get; set; }

    [MPKey(1), MP2Key(1)]
    [SystemTextJsonProperty("svip")]
    public XunYouVipEndTimeResponseDataSVIP? SVIP { get; set; }

    /// <summary>
    /// 到期时间 UnixSeconds
    /// </summary>
    [MPKey(2), MP2Key(2)]
    [SystemTextJsonProperty("etime")]
    public long ExpireTime { get; set; }
}