namespace Mobius.Models.GameLibrary.Request;

/// <summary>
/// 同步用户 Steam 信息请求
/// </summary>
/// <param name="SteamUserId64"> Steam 用户 Id</param>
[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial record class SyncSteamUserAppInfoRequest(
    [property: MPKey(0), MP2Key(0)] string SteamUserId64);
