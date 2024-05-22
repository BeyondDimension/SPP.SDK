using SR = Mobius.Resources.Strings;

namespace Mobius.Enums.App;

/// <summary>
/// 应用程序更新失败状态码
/// </summary>
public enum AppUpdateFailCode : byte
{
    /// <summary>
    /// <inheritdoc cref="SR.DownloadUpdateFail"/>
    /// </summary>
    DownloadUpdateFail,

    /// <summary>
    /// <inheritdoc cref="SR.UpdatePackVerificationFail"/>
    /// </summary>
    UpdatePackVerificationFail,

    /// <summary>
    /// <inheritdoc cref="SR.UpdatePackCacheHashInvalidDeleteFileFail_"/>
    /// </summary>
    UpdatePackCacheHashInvalidDeleteFileFail_,

    /// <summary>
    /// <inheritdoc cref="SR.UpdateEnumOutOfRange"/>
    /// </summary>
    UpdateEnumOutOfRange,

    /// <summary>
    /// <inheritdoc cref="SR.UpdateUnpackFail"/>
    /// </summary>
    UpdateUnpackFail,
}

/// <summary>
/// Enum 扩展 <see cref="AppUpdateFailCode"/>
/// </summary>
public static partial class AppUpdateFailCodeEnumExtensions
{
    /// <summary>
    /// 将枚举值转换为显示字符串
    /// </summary>
    /// <param name="appUpdateFailCode"></param>
    /// <param name="args"></param>
    /// <returns></returns>
    public static string ToString2(this AppUpdateFailCode appUpdateFailCode, params string[] args)
    {
        return appUpdateFailCode switch
        {
            AppUpdateFailCode.DownloadUpdateFail => SR.DownloadUpdateFail,
            AppUpdateFailCode.UpdatePackVerificationFail => SR.UpdatePackVerificationFail,
            AppUpdateFailCode.UpdatePackCacheHashInvalidDeleteFileFail_ => SR.UpdatePackCacheHashInvalidDeleteFileFail_.Format(args),
            AppUpdateFailCode.UpdateEnumOutOfRange => SR.UpdateEnumOutOfRange,
            AppUpdateFailCode.UpdateUnpackFail => SR.UpdateUnpackFail,
            _ => appUpdateFailCode.ToString(),
        };
    }
}