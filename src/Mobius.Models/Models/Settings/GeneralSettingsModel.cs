namespace Mobius.Models.Settings;

/// <summary>
/// 通用设置项模型
/// </summary>
[MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial record class GeneralSettingsModel
{
    /// <summary>
    /// 自动检查应用更新
    /// </summary>
    [MP2Key(0), JsonPropertyOrder(0)]
    public bool AutoCheckAppUpdate { get; set; } = DefaultAutoCheckAppUpdate;

    /// <summary>
    /// 自动检查应用更新的默认值
    /// </summary>
    public const bool DefaultAutoCheckAppUpdate = true;

    /// <summary>
    /// 选择下载更新渠道
    /// </summary>
    [MP2Key(1), JsonPropertyOrder(1)]
    public UpdateChannelType UpdateChannel { get; set; } = DefaultUpdateChannel;

    /// <summary>
    /// 选择下载更新渠道的默认值
    /// </summary>
    public const UpdateChannelType DefaultUpdateChannel = UpdateChannelType.Auto;

    /// <summary>
    /// 开机自启动
    /// </summary>
    [MP2Key(2), JsonPropertyOrder(2)]
    public bool AutoRunOnStartup { get; set; }

    /// <summary>
    /// 启动时最小化
    /// </summary>
    [MP2Key(3), JsonPropertyOrder(3)]
    public bool MinimizeOnStartup { get; set; }

    /// <summary>
    /// 启用托盘图标
    /// </summary>
    [MP2Key(4), JsonPropertyOrder(4)]
    public bool TrayIcon { get; set; } = DefaultTrayIcon;

    /// <summary>
    /// 启用托盘图标的默认值
    /// </summary>
    public const bool DefaultTrayIcon =
        true;

    /// <summary>
    /// 启用消息推送通知
    /// </summary>
    [MP2Key(5), JsonPropertyOrder(5)]
    public bool MessagePopupNotification { get; set; } = DefaultMessagePopupNotification;

    /// <summary>
    /// 启用消息推送通知的默认值
    /// </summary>
    public const bool DefaultMessagePopupNotification = true;

    /// <summary>
    /// 游戏列表使用本地缓存
    /// </summary>
    [MP2Key(6), JsonPropertyOrder(6)]
    public bool GameListUseLocalCache { get; set; }

    /// <summary>
    /// 文本阅读器提供商名称，例如 Notepad/VSCode
    /// </summary>
    [MP2Key(7), JsonPropertyOrder(7)]
    public TextReaderProvider TextReaderProviderName { get; set; } = DefaultTextReaderProvider;

    /// <summary>
    /// 文本阅读器提供商名称的默认值
    /// </summary>
    public const TextReaderProvider DefaultTextReaderProvider = TextReaderProvider.VSCode;

    /// <summary>
    /// Hosts 文件编码类型
    /// </summary>
    [MP2Key(8), JsonPropertyOrder(8)]
    public EncodingType HostsFileEncodingType { get; set; }

    /// <summary>
    /// 是否使用硬件加速
    /// </summary>
    [MP2Key(9), JsonPropertyOrder(9)]
    public bool GPU { get; set; } = DefaultGPU;

    /// <summary>
    /// 是否使用硬件加速的默认值
    /// </summary>
    public const bool DefaultGPU = true;

    /// <summary>
    /// 使用本机 OpenGL
    /// </summary>
    [MP2Key(10), JsonPropertyOrder(10)]
    public bool NativeOpenGL { get; set; }

    /// <summary>
    /// 屏幕捕获/允许截图，在一些含有机密的页面上是否允许截图，默认为 <see langword="false"/>
    /// </summary>
    [MP2Key(11), JsonPropertyOrder(11)]
    public bool ScreenCapture { get; set; }

    /// <summary>
    /// 禁用插件
    /// </summary>
    [MP2Key(12), JsonPropertyOrder(12)]
    public HashSet<string>? DisablePlugins { get; set; }

    /// <summary>
    /// 插件安全模式
    /// </summary>
    [MP2Key(13), JsonPropertyOrder(13)]
    public bool PluginSafeMode { get; set; } = DefaultPluginSafeMode;

    /// <summary>
    /// 插件安全模式的默认值
    /// </summary>
    public const bool DefaultPluginSafeMode = true;

    /// <summary>
    /// 最后查看通知时间
    /// </summary>
    [MP2Key(14), JsonPropertyOrder(14)]
    public DateTimeOffset LastLookNoticeDateTime { get; set; }

    #region 配置应用程序的 Web 代理

    /// <summary>
    /// Web 代理模式
    /// </summary>
    [MP2Key(15), JsonPropertyOrder(15)]
    public AppWebProxyMode WebProxyMode { get; set; }

    /// <summary>
    /// Web 自定义代理 Host
    /// </summary>
    [MP2Key(16), JsonPropertyOrder(16)]
    public string? CustomWebProxyModeHost { get; set; }

    /// <summary>
    /// Web 自定义代理 Port
    /// </summary>
    [MP2Key(17), JsonPropertyOrder(17)]
    public int CustomWebProxyModePort { get; set; }

    /// <summary>
    /// Web 自定义代理 Address
    /// </summary>
    [MP2Key(18), JsonPropertyOrder(18)]
    public string? CustomWebProxyModeAddress { get; set; }

    /// <summary>
    /// Web 自定义代理 BypassOnLocal
    /// </summary>
    [MP2Key(19), JsonPropertyOrder(19)]
    public bool CustomWebProxyModeBypassOnLocal { get; set; }

    /// <summary>
    /// Web 自定义代理 NetworkCredential.UserName
    /// </summary>
    [MP2Key(20), JsonPropertyOrder(20)]
    public string? CustomWebProxyModeCredentialUserName { get; set; }

    /// <summary>
    /// Web 自定义代理 NetworkCredential.Password
    /// </summary>
    [MP2Key(21), JsonPropertyOrder(21)]
    public string? CustomWebProxyModeCredentialPassword { get; set; }

    /// <summary>
    /// Web 自定义代理 NetworkCredential.Domain
    /// </summary>
    [MP2Key(22), JsonPropertyOrder(22)]
    public string? CustomWebProxyModeCredentialDomain { get; set; }

    #endregion
}