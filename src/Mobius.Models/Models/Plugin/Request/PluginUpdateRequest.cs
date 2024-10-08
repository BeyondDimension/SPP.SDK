namespace Mobius.Models.Plugin.Request;

/// <summary>
/// 插件分类DTO
/// </summary>
[MP2Obj(GenerateType.VersionTolerant, SerializeLayout.Sequential)]
public sealed partial class PluginUpdateRequest
{
    public string UniqueName { get; set; } = "";

    public string? VersionNumber { get; set; }
}
