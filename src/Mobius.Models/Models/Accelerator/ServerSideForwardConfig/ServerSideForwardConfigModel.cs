namespace Mobius.Models.Accelerator.ServerSideForwardConfig;

[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial record class ServerSideForwardConfigModel
{
    [MPKey(0), MP2Key(0)]
    public string Key { get; set; }

    [MPKey(1), MP2Key(1)]
    public string MatchPattern { get; set; }

    [MPKey(2), MP2Key(2)]
    public ServerSideForwardDestMappingModel[] ForwardDestList { get; set; }

    [MPKey(3), MP2Key(3)]
    public UserType? AccessLevel { get; set; } = null;

    [MPKey(4), MP2Key(4)]
    public string? Remarks { get; set; }

    [MPConstructor, MP2Constructor]
    public ServerSideForwardConfigModel(string key, string matchPattern, ServerSideForwardDestMappingModel[] forwardDestList, UserType? accessLevel, string? remarks)
    {
        Key = key;
        MatchPattern = matchPattern;
        ForwardDestList = forwardDestList;
        AccessLevel = accessLevel;
        Remarks = remarks;
    }

    public ServerSideForwardConfigModel() : this(string.Empty, string.Empty, Array.Empty<ServerSideForwardDestMappingModel>(), null, null)
    {
    }
}