namespace Mobius.Models.GameLibrary.Jobs.Distributed;

[MPObj(true), MP2Obj(GenerateType.VersionTolerant, SerializeLayout.Sequential)]
public partial record struct RateMediaAgencyModel(
    string MediaAgencyName,
    decimal MetaRate,
    decimal UserMetaRate,
    string Url
    );
