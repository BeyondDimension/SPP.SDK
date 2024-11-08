namespace Mobius.Models.GameLibrary.Jobs.Distributed;

[MPObj(true), MP2Obj(GenerateType.VersionTolerant, SerializeLayout.Sequential)]
public partial record struct GamePriceRefreshDistributedModel(bool IsFree, bool IsOnSale, Dictionary<string, ImmutableArray<GamePriceSubModel>> PackagesOfRegion);