namespace Mobius.Models.GameLibrary.Jobs.Distributed;

[MPObj(true), MP2Obj(GenerateType.VersionTolerant, SerializeLayout.Sequential)]
public partial record struct GamePriceSubModel(string SubName, int SubId, decimal? Original, decimal? Final);
