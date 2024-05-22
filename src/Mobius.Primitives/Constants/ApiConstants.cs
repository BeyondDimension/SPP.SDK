namespace Mobius.Constants;

/// <summary>
/// SppWebApi 常量
/// </summary>
public static partial class ApiConstants
{
    /// <summary>
    /// 请求头授权前缀
    /// </summary>
    public const string Basic = "Bearer";

#if DEBUG
    /// <summary>
    /// use System.MediaTypeNames
    /// </summary>
    [Obsolete("use System.MediaTypeNames", true)]
    public static class MediaTypeNames
    {
    }
#endif

    /// <summary>
    /// 获取 Http 头 Referrer 的值
    /// </summary>
    /// <param name="devicePlatform"></param>
    /// <param name="appVersion"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static string GetReferrer(DevicePlatform2 devicePlatform, string appVersion)
        => $"{UrlConstants.CUSTOM_URL_SCHEME}{devicePlatform}/{appVersion}";

    /// <summary>
    /// 自定义 Http 头
    /// </summary>
    public static class Headers
    {
        /// <summary>
        /// 自定义 Http 请求头
        /// </summary>
        public static class Request
        {
            /// <summary>
            /// App 版本号
            /// </summary>
            public const string AppVersion = "App-Version";

            /// <summary>
            /// 安全密钥 ByteArray，Base64Url 编码
            /// </summary>
            public const string SecurityKey = "App-SKey";

            /// <summary>
            /// 安全密钥 ByteArray，Hex 编码
            /// </summary>
            public const string SecurityKeyHex = "App-SKey-Hex";

            /// <summary>
            /// 安全密钥填充
            /// </summary>
            public const string SecurityKeyPadding = "App-SKey-Padding";
        }

        /// <summary>
        /// 自定义 Http 响应头
        /// </summary>
        public static class Response
        {
            /// <summary>
            /// App 是否弃用
            /// </summary>
            public const string AppObsolete = "App-Obsolete";
        }
    }

    /// <summary>
    /// 短信间隔，60秒
    /// </summary>
    public const int SMSInterval = 60;

    /// <summary>
    /// 实际短信间隔
    /// </summary>
    public const double SMSIntervalActually = 79.5;
}