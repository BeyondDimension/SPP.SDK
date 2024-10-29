namespace Mobius.Models.Accelerator.YarpConfig;

[MP2Obj(MP2SerializeLayout.Explicit)]
public readonly partial record struct ScriptIPCModel(
    [property: MP2Key(0)]
    int LocalId,
    [property: MP2Key(1)]
    string CachePath,
    [property: MP2Key(2)]
    string[] MatchDomainNamesArray,
    [property: MP2Key(3)]
    string ExcludeDomainNames,
    [property: MP2Key(4)]
    long Order
    ) : IScriptConfig
{
    DomainPattern? IScriptConfig.ExcludeDomainPattern => string.IsNullOrWhiteSpace(ExcludeDomainNames) ? null : new DomainPattern(ExcludeDomainNames);
}