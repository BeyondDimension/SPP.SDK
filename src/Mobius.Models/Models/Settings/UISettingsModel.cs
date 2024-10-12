namespace Mobius.Models.Settings;

/// <summary>
/// UI 设置项模型
/// </summary>
[MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial record class UISettingsModel
{
    #region 主题

    /// <summary>
    /// 主题
    /// </summary>
    [MP2Key(0), JsonPropertyOrder(0)]
    public AppTheme Theme { get; set; } = DefaultTheme;

    /// <summary>
    /// 主题的默认值
    /// </summary>
    public const AppTheme DefaultTheme = AppTheme.FollowingSystem;

    /// <summary>
    /// 主题强调色（16 进制 RGB 字符串）
    /// </summary>
    [MP2Key(1), JsonPropertyOrder(1)]
    public string? ThemeAccent { get; set; } = DefaultThemeAccent;

    /// <summary>
    /// 主题强调色（16 进制 RGB 字符串）的默认值
    /// </summary>
    public const string DefaultThemeAccent = "#FF0078D7";

    /// <summary>
    /// 从系统中获取主题强调色
    /// </summary>
    [MP2Key(2), JsonPropertyOrder(2)]
    public bool UseSystemThemeAccent { get; set; } = DefaultUseSystemThemeAccent;

    /// <summary>
    /// 从系统中获取主题强调色的默认值
    /// </summary>
    public const bool DefaultUseSystemThemeAccent = true;

    #endregion

    /// <summary>
    /// 语言
    /// </summary>
    [MP2Key(3), JsonPropertyOrder(3)]
    public string? Language { get; set; }

    /// <summary>
    /// 不再提示的消息框
    /// </summary>
    [MP2Key(4), JsonPropertyOrder(4)]
    public HashSet<MBDontPromptType>? MessageBoxDontPrompts { get; set; }

    /// <summary>
    /// 是否显示广告
    /// </summary>
    [MP2Key(5), JsonPropertyOrder(5)]
    public bool IsShowAdvertisement { get; set; } = DefaultIsShowAdvertisement;

    /// <summary>
    /// 是否显示广告的默认值
    /// </summary>
    public const bool DefaultIsShowAdvertisement = true;

    /// <summary>
    /// 窗口位置大小
    /// </summary>
    [MP2Key(6), JsonPropertyOrder(6)]
    public ConcurrentDictionary<string, SizePositionModel>? WindowSizePositions { get; set; }

    /// <summary>
    /// 字体
    /// </summary>
    [MP2Key(7), JsonPropertyOrder(7)]
    public string? FontName { get; set; } = DefaultFontName;

    /// <summary>
    /// 字体的默认值
    /// <para>https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.media.fontfamily.xamlautofontfamily?view=winrt-22000</para>
    /// </summary>
    public const string DefaultFontName = "XamlAutoFontFamily";

    /// <summary>
    /// 库存游戏网格布局大小
    /// </summary>
    [MP2Key(8), JsonPropertyOrder(8)]
    public int GameListGridSize { get; set; } = DefaultGameListGridSize;

    /// <summary>
    /// 库存游戏网格布局大小的默认值
    /// </summary>
    public const int DefaultGameListGridSize = 150;

    /// <summary>
    /// 圆角
    /// </summary>
    [MP2Key(9), JsonPropertyOrder(9)]
    public bool Fillet { get; set; }

    #region WindowBackground 窗口背景

    /// <summary>
    /// 窗口背景不透明度
    /// </summary>
    [MP2Key(10), JsonPropertyOrder(10)]
    public double WindowBackgroundOpacity { get; set; } = DefaultWindowBackgroundOpacity;

    /// <summary>
    /// 窗口背景不透明度的默认值
    /// </summary>
    public static readonly double DefaultWindowBackgroundOpacity =
        OSHelper.IsWindows11AtLeast() ? .0 : .8;

    /// <summary>
    /// 窗口背景材质
    /// </summary>
    [MP2Key(11), JsonPropertyOrder(11)]
    public WindowBackgroundMaterial WindowBackgroundMaterial { get; set; } = DefaultWindowBackgroundMaterial;

    /// <summary>
    /// 窗口背景材质的默认值
    /// </summary>
    public static readonly WindowBackgroundMaterial DefaultWindowBackgroundMaterial =
        OSHelper.IsWindows11AtLeast() ?
        WindowBackgroundMaterial.Mica :
        WindowBackgroundMaterial.AcrylicBlur;

    /// <summary>
    /// 动态桌面背景
    /// </summary>
    [MP2Key(12), JsonPropertyOrder(12)]
    public bool WindowBackgroundDynamic { get; set; }

    /// <summary>
    /// 是否打开自定义背景图像
    /// </summary>
    [MP2Key(13), JsonPropertyOrder(13)]
    public bool WindowBackgroundCustomImage { get; set; }

    string? _WindowBackgroundCustomImagePath = DefaultWindowBackgroundCustomImagePath;

    /// <summary>
    /// 自定义背景图像路径
    /// </summary>
    [MP2Key(14), JsonPropertyOrder(14)]
    public string? WindowBackgroundCustomImagePath
    {
        get => _WindowBackgroundCustomImagePath;
        set
        {
            if (string.Equals(value,
                DefaultWindowBackgroundCustomImagePathOld, // 兼容 WattToolkit.sln
                StringComparison.OrdinalIgnoreCase))
            {
                value = DefaultWindowBackgroundCustomImagePath;
            }
            if (DefaultWindowBackgroundCustomImagePath2 != DefaultWindowBackgroundCustomImagePath &&
                string.Equals(value,
                DefaultWindowBackgroundCustomImagePath2,
                StringComparison.OrdinalIgnoreCase))
            {
                value = DefaultWindowBackgroundCustomImagePath;
            }
            _WindowBackgroundCustomImagePath = value;
        }
    }

    /// <summary>
    /// 自定义背景图像路径的默认值
    /// </summary>
    public const string DefaultWindowBackgroundCustomImagePath =
#if PROJ_MOBIUS
        XamlConstants.Assets_Back;
#else
        DefaultWindowBackgroundCustomImagePath2;
#endif

    const string DefaultWindowBackgroundCustomImagePath2 = "avares://Mobius/UI/Assets/back.png";
    const string DefaultWindowBackgroundCustomImagePathOld = "avares://BD.WTTS.Client.Avalonia/UI/Assets/back.png";

    /// <summary>
    /// 自定义背景图像不透明度
    /// </summary>
    [MP2Key(15), JsonPropertyOrder(15)]
    public double WindowBackgroundCustomImageOpacity { get; set; } = DefaultWindowBackgroundCustomImageOpacity;

    /// <summary>
    /// 自定义背景图像不透明度的默认值
    /// </summary>
    public const double DefaultWindowBackgroundCustomImageOpacity = .8;

    /// <summary>
    /// 自定义背景图像缩放方式
    /// </summary>
    [MP2Key(16), JsonPropertyOrder(16)]
    public XamlMediaStretch WindowBackgroundCustomImageStretch { get; set; } = DefaultWindowBackgroundCustomImageStretch;

    /// <summary>
    /// 自定义背景图像缩放方式的默认值
    /// </summary>
    public const XamlMediaStretch DefaultWindowBackgroundCustomImageStretch = XamlMediaStretch.UniformToFill;

    #endregion

    /// <summary>
    /// 菜单排序
    /// </summary>
    [MP2Key(17), JsonPropertyOrder(17)]
    public HashSet<string>? SortMenuTabs { get; set; }

    /// <summary>
    /// 程序启动时默认页
    /// </summary>
    [MP2Key(18), JsonPropertyOrder(18)]
    public string? StartDefaultPageName { get; set; }
}