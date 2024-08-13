namespace Mobius.Constants;

static partial class UrlConstants
{
    /// <summary>
    /// 当前应用程序的硬编码名称，此值不可更改！
    /// <para></para>
    /// 通常用于文件，文件夹名，等不可变值。
    /// <para></para>
    /// 可更变名称的值为 AssemblyInfo.Trademark
    /// </summary>
    public const string HARDCODED_APP_NAME = "Steam++";

    /// <inheritdoc cref="HARDCODED_APP_NAME"/>
    public const string HARDCODED_APP_NAME_NEW2 = "Watt Toolkit";

#if PROJ_MOBIUS || PROJ_NATIVEHOST
    const string DotNetUrl_ = "https://dotnet.microsoft.com/{0}";

    /// <summary>
    /// .NET 官方网址
    /// </summary>
    /// <param name="cultureInfo"></param>
    /// <returns></returns>
#if NET35 || NET40
    [MethodImpl((MethodImplOptions)0x100)]
#else
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static string DotNetUrl(CultureInfo? cultureInfo = null) => string.Format(DotNetUrl_, GetCultureInfoStringByDotNetMicrosoftCom(cultureInfo));

#if NET35 || NET40
    [MethodImpl((MethodImplOptions)0x100)]
#else
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static string GetCultureInfoStringByDotNetMicrosoftCom(CultureInfo? cultureInfo = null)
    {
        cultureInfo ??= CultureInfo.CurrentUICulture;
        if (cultureInfo.IsMatch(AssemblyInfo.CultureName_SimplifiedChinese))
            return "zh-cn";
        //else if (cultureInfo.IsMatch(AssemblyInfo.CultureName_TraditionalChinese))
        //    return "zh";
        else if (cultureInfo.IsMatch(AssemblyInfo.CultureName_Spanish))
            return "es-es";
        else if (cultureInfo.IsMatch(AssemblyInfo.CultureName_Italian))
            return "it-it";
        else if (cultureInfo.IsMatch(AssemblyInfo.CultureName_Japanese))
            return "ja-jp";
        else if (cultureInfo.IsMatch(AssemblyInfo.CultureName_Korean))
            return "ko-kr";
        else if (cultureInfo.IsMatch(AssemblyInfo.CultureName_Russian))
            return "ru-ru";
        else
            return "en-us";
    }

    const string DotNetRuntimeDownloadUrl___ = "https://dotnet.microsoft.com/{0}/download/dotnet/{1}.{2}";

    /// <summary>
    /// .NET 运行时官方下载网址
    /// </summary>
    /// <param name="dotnet_version_major"></param>
    /// <param name="dotnet_version_minor"></param>
    /// <param name="cultureInfo"></param>
    /// <returns></returns>
#if NET35 || NET40
    [MethodImpl((MethodImplOptions)0x100)]
#else
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static string DotNetRuntimeDownloadUrl(int dotnet_version_major, int dotnet_version_minor, CultureInfo? cultureInfo = null)
    {
        var url = string.Format(DotNetRuntimeDownloadUrl___,
            GetCultureInfoStringByDotNetMicrosoftCom(cultureInfo),
            dotnet_version_major,
            dotnet_version_minor);
        return url;
    }
#endif
}
