namespace Mobius.Models.Accelerator.ServerSideForwardConfig;

[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial record class ServerSideForwardDestModel(
    [property: MPKey(0), MP2Key(0)] string Scheme,
    [property: MPKey(1), MP2Key(1)] string Host
    );