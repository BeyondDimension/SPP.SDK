using SR = Mobius.Resources.Strings;

namespace Mobius.Enums.App.PlatformNotification;

/// <summary>
/// 通知渠道类型(一个渠道可包含一个或多个 Avalonia.Controls.Notifications.NotificationType)
/// <list type="bullet">
///   <item>
///     <term>iOS：</term>
///   </item>
///   <item>
///     <term>Android：将枚举通过 GetChannelId 转换为 <see cref="string"/> 用作 NotificationCompat.Builder 中的 channelId</term>
///   </item>
///   <item>
///     <term>UWP：</term>
///   </item>
///   <item>
///     <term>Win32：</term>
///   </item>
/// </list>
/// <para>添加新的枚举常量注意事项：</para>
/// <para>在<see cref="PlatformNotificationType_Channel_EnumExtensions.GetName(PlatformNotificationChannelType)"/>中添加渠道名称</para>
/// <para>在<see cref="PlatformNotificationType_Channel_EnumExtensions.GetDescription(PlatformNotificationChannelType)"/>中添加渠道描述</para>
/// <para>在<see cref="PlatformNotificationType_Channel_EnumExtensions.GetImportanceLevel(PlatformNotificationChannelType)"/>中添加渠道重要性级别</para>
/// </summary>
public enum PlatformNotificationChannelType
{
    /// <inheritdoc cref="PlatformNotificationType.NewVersion"/>
    NewVersion = 2,

    /// <inheritdoc cref="PlatformNotificationType.Announcement"/>
    Announcement,

    /// <inheritdoc cref="PlatformNotificationType.Message"/>
    Message,

    /// <summary>
    /// Android 前台服务
    /// <para><see cref="PlatformNotificationType.ProxyForegroundService"/></para>
    /// <para><see cref="PlatformNotificationType.ArchiSteamFarmForegroundService"/></para>
    /// </summary>
    ForegroundService,
}

/// <summary>
/// Enum 扩展 <see cref="PlatformNotificationType"/> AND <see cref="PlatformNotificationChannelType"/>
/// </summary>
public static partial class PlatformNotificationType_Channel_EnumExtensions
{
    /// <summary>
    /// 获取所属的通知渠道
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static PlatformNotificationChannelType GetChannel(this PlatformNotificationType value) => value switch
    {
        PlatformNotificationType.Announcement => PlatformNotificationChannelType.Announcement,
        PlatformNotificationType.NewVersion => PlatformNotificationChannelType.NewVersion,
        PlatformNotificationType.Message => PlatformNotificationChannelType.Message,
        PlatformNotificationType.ProxyForegroundService or
        PlatformNotificationType.ArchiSteamFarmForegroundService => PlatformNotificationChannelType.ForegroundService,
        _ => throw new ArgumentOutOfRangeException(nameof(value), value, null),
    };

    /// <summary>
    /// 获取渠道的用户可见名称
    /// <para>建议的最大长度为 40 个字符，如果该值太长，可能会被截断</para>
    /// <para>参考：https://developer.android.google.cn/reference/android/app/NotificationChannel?hl=en#setName%28java.lang.CharSequence%29 </para>
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string GetName(this PlatformNotificationChannelType value)
    {
        return value switch
        {
            PlatformNotificationChannelType.Announcement => SR.NotificationChannelType_Name_Announcement,
            PlatformNotificationChannelType.NewVersion => SR.NotificationChannelType_Name_NewVersion,
            PlatformNotificationChannelType.Message => SR.NotificationChannelType_Name_Message,
            PlatformNotificationChannelType.ForegroundService => SR.NotificationChannelType_Name_ForegroundService,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null),
        };
    }

    /// <summary>
    /// 获取渠道的用户可见描述
    /// <para>建议的最大长度为300个字符，如果该值太长，可能会被截断</para>
    /// <para>参考：https://developer.android.google.cn/reference/android/app/NotificationChannel?hl=en#setDescription%28java.lang.String%29 </para>
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string GetDescription(this PlatformNotificationChannelType value)
    {
        return value switch
        {
            PlatformNotificationChannelType.Announcement => SR.NotificationChannelType_Description_Announcement,
            PlatformNotificationChannelType.NewVersion => SR.NotificationChannelType_Description_NewVersion,
            PlatformNotificationChannelType.Message => SR.NotificationChannelType_Description_Message,
            PlatformNotificationChannelType.ForegroundService => SR.NotificationChannelType_Description_ForegroundService,
            _ => string.Empty,
        };
    }

    /// <summary>
    /// 获取渠道的重要性级别
    /// <para>参考：https://developer.android.google.cn/reference/android/app/NotificationChannel?hl=en#getImportance%28%29 </para>
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static NotificationImportanceLevel GetImportanceLevel(this PlatformNotificationChannelType value)
        => value switch
        {
            PlatformNotificationChannelType.Announcement => NotificationImportanceLevel.High,
            _ => NotificationImportanceLevel.Medium,
        };
}