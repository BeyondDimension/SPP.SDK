namespace Mobius.Models.Plugin.Response;

/// <summary>
/// 插件检查更新 Model 避免 更新内容过大 内容单独请求
/// </summary>
[MP2Obj(GenerateType.VersionTolerant, SerializeLayout.Sequential)]
public sealed partial class PluginUpdateDetailModel
{
    /// <summary>
    /// 插件 Id
    /// </summary>
    public string UniqueName { get; set; } = "";

    /// <summary>
    /// 最新版本号 如果有更新
    /// </summary>
    public string? NewVersionNumber { get; set; }

    /// <summary>
    /// 更新地址 有更新会有 Url
    /// </summary>
    public string? UpdateUrl { get; set; }

    /// <summary>
    /// 最低支持版本 有数据代表不支持程序版本不满足
    /// </summary>
    public string? MinVersion { get; set; }

    /// <summary>
    /// 错误消息
    /// </summary>
    public string? Message { get; set; }
}
