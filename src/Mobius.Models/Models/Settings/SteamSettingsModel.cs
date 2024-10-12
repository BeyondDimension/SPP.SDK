namespace Mobius.Models.Settings;

/// <summary>
/// UI 设置项模型
/// </summary>
[MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial record class SteamSettingsModel
{
    /// <summary>
    /// Steam 启动参数
    /// </summary>
    [MP2Key(0), JsonPropertyOrder(0)]
    public string? SteamStratParameter { get; set; }

    /// <summary>
    /// Steam 皮肤
    /// </summary>
    [MP2Key(1), JsonPropertyOrder(1)]
    public string? SteamSkin { get; set; }

    /// <summary>
    /// Steam 默认程序路径
    /// </summary>
    [MP2Key(2), JsonPropertyOrder(2)]
    public string? SteamProgramPath { get; set; }

    /// <summary>
    /// 自动运行 Steam
    /// </summary>
    [MP2Key(3), JsonPropertyOrder(3)]
    public bool IsAutoRunSteam { get; set; }

    /// <summary>
    /// Steam 启动时最小化到托盘
    /// </summary>
    [MP2Key(4), JsonPropertyOrder(4)]
    public bool IsRunSteamMinimized { get; set; }

    /// <summary>
    /// Steam 启动时不检查更新
    /// </summary>
    [MP2Key(5), JsonPropertyOrder(5)]
    public bool IsRunSteamNoCheckUpdate { get; set; }

    /// <summary>
    /// Steam 启动时模拟为蒸汽平台（Steam 国服）启动
    /// </summary>
    [MP2Key(6), JsonPropertyOrder(6)]
    public bool IsRunSteamChina { get; set; } = false;

    /// <summary>
    /// Steam 以旧版 VGUI 启动
    /// </summary>
    [MP2Key(7), JsonPropertyOrder(7)]
    public bool IsRunSteamVGUI { get; set; }

    /// <summary>
    /// Steam 登录时弹出消息通知
    /// </summary>
    [MP2Key(8), JsonPropertyOrder(8)]
    public bool IsEnableSteamLaunchNotification { get; set; }

    /// <summary>
    /// Steam 下载完成执行任务
    /// </summary>
    [MP2Key(9), JsonPropertyOrder(9)]
    public OSExitMode DownloadCompleteSystemEndMode { get; set; } = DefaultDownloadCompleteSystemEndMode;

    /// <summary>
    /// Steam 下载完成执行任务的默认值
    /// </summary>
    public const OSExitMode DefaultDownloadCompleteSystemEndMode = OSExitMode.Sleep;

    /// <summary>
    /// Steam 以管理员权限运行
    /// </summary>
    [MP2Key(10), JsonPropertyOrder(10)]
    public bool IsRunSteamAdministrator { get; set; }
}
