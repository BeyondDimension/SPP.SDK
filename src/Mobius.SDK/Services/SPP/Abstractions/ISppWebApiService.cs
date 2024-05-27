namespace Mobius.Services.SPP.Abstractions;

/// <summary>
/// SppWebApi 服务（客户端侧调用 SDK Client）
/// </summary>
public partial interface ISppWebApiService
{
    /// <summary>
    /// 通过 <see cref="Ioc"/> 获取当前服务实例
    /// </summary>
    static ISppWebApiService Instance => Ioc.Get<ISppWebApiService>();

    /// <summary>
    /// 是否在设计器中运行
    /// </summary>
    bool IsDesignMode { get; }

    /// <summary>
    /// 禁用客户端本地模型验证
    /// </summary>
    internal static bool DisableModelValidator { get; set; }

    /// <inheritdoc cref="Serializable.ImplType"/>
    internal static Serializable.ImplType SerializableImplType { get; set; } = Serializable.ImplType.MemoryPack;

    private static readonly Lazy<ClientPlatform> clientPlatform = new(() =>
    {
        var platform = DeviceInfo2.Platform();
        switch (platform)
        {
#if WINDOWS
            case DevicePlatform2.Windows:
            case DevicePlatform2.WinUI:
            case DevicePlatform2.UWP:
                switch (RuntimeInformation.ProcessArchitecture)
                {
                    case Architecture.X86:
                        return OSHelper.IsPublishToStore ?
                        ClientPlatform.Win32StoreX86 : ClientPlatform.Win32X86;
                    case Architecture.X64:
                        return OSHelper.IsPublishToStore ?
                        ClientPlatform.Win32StoreX64 : ClientPlatform.Win32X64;
                    case Architecture.Arm64:
                        return OSHelper.IsPublishToStore ?
                        ClientPlatform.Win32StoreArm64 : ClientPlatform.Win32Arm64;
                }
                break;
#elif ANDROID
            case DevicePlatform2.WSA:
            case DevicePlatform2.AndroidUnknown:
            case DevicePlatform2.AndroidPhone:
            case DevicePlatform2.AndroidTablet:
            case DevicePlatform2.AndroidDesktop:
            case DevicePlatform2.AndroidTV:
            case DevicePlatform2.AndroidWatch:
            case DevicePlatform2.AndroidVirtual:
            case DevicePlatform2.ChromeOS:
                switch (RuntimeInformation.ProcessArchitecture)
                {
                    case Architecture.X86:
                        return ClientPlatform.AndroidPadX86;
                    case Architecture.X64:
                        return ClientPlatform.AndroidPhoneX64;
                    case Architecture.Arm64:
                        return ClientPlatform.AndroidPhoneArm64;
                    case Architecture.Arm:
                        return ClientPlatform.AndroidPhoneArm;
                }
                break;
#elif MACCATALYST || MACOS || IOS
            case DevicePlatform2.iOS:
            case DevicePlatform2.iPadOS:
            case DevicePlatform2.macOS:
            case DevicePlatform2.MacCatalyst:
            case DevicePlatform2.watchOS:
            case DevicePlatform2.tvOS:
                switch (DeviceInfo2.Idiom())
                {
#if !IOS
                    case DeviceIdiom.Desktop:
                        switch (RuntimeInformation.ProcessArchitecture)
                        {
                            case Architecture.X64:
                                return ClientPlatform.macOSX64;
                            case Architecture.Arm64:
                                return ClientPlatform.macOSArm64;
                        }
                        break;
#endif
#if !MACOS
                    case DeviceIdiom.Phone:
                        return ClientPlatform.iOSArm64;
                    case DeviceIdiom.Tablet:
                        return ClientPlatform.iPadOSArm64;
                    case DeviceIdiom.TV:
                        return ClientPlatform.tvOSArm64;
                    case DeviceIdiom.Watch:
                        return ClientPlatform.watchOSArm64;
#endif
                }
                break;
#else
            case DevicePlatform2.Linux:
                switch (RuntimeInformation.ProcessArchitecture)
                {
                    case Architecture.X64:
                        return ClientPlatform.LinuxX64;
                    case Architecture.Arm64:
                        return ClientPlatform.LinuxArm64;
                    case Architecture.Arm:
                        return ClientPlatform.LinuxArm;
                }
                break;
#endif
        }
        return default;
    }, LazyThreadSafetyMode.ExecutionAndPublication);

    /// <summary>
    /// 获取当前的 <see cref="ClientPlatform"/>
    /// </summary>
    static ClientPlatform ClientPlatform => clientPlatform.Value;

#if DEBUG
    /// <summary>
    /// use UrlConstants.ApiBaseUrl
    /// </summary>
    [Obsolete("use UrlConstants.ApiBaseUrl", true)]
    string ApiBaseUrl => UrlConstants.ApiBaseUrl;

    ///// <summary>
    ///// 用于测试的信息
    ///// </summary>
    ///// <returns></returns>
    //Task<string> Info();
#endif
}
