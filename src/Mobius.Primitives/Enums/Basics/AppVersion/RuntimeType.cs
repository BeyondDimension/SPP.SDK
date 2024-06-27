namespace Mobius.Enums.Basics.AppVersion;

/// <summary>
/// 运行时类型
/// </summary>
[Flags]
public enum RuntimeType
{
    AapNetCoreRuntime = 1,

    DesktopRuntime = 2,

    Runtime = 3,
}
