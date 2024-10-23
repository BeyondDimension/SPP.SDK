namespace Mobius.Models.GameLibrary.Jobs.Distributed;

[MPObj(true), MP2Obj(GenerateType.VersionTolerant, MP2SerializeLayout.Sequential)]
public partial record struct AchievementModel(
    string Url,
    string Name,
    string Describe,
    string UnlockCondition
    );
