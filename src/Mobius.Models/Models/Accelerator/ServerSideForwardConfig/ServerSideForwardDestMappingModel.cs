namespace Mobius.Models.Accelerator.ServerSideForwardConfig;

[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial record class ServerSideForwardDestMappingModel
{
    [MPConstructor, MP2Constructor]
    public ServerSideForwardDestMappingModel(ServerSideForwardDestModel from, ServerSideForwardDestModel to)
    {
        From = from;
        To = to;
    }

    public ServerSideForwardDestMappingModel() : this(new(string.Empty, string.Empty), new(string.Empty, string.Empty))
    {
    }

    [MPKey(0), MP2Key(0)]
    public ServerSideForwardDestModel From { get; set; }

    [MPKey(1), MP2Key(1)]
    public ServerSideForwardDestModel To { get; set; }
}