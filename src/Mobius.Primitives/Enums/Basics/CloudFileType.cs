namespace Mobius.Enums.Basics;

/// <summary>
/// 静态资源文件类型
/// </summary>
public enum CloudFileType
{
    // 不使用值为 0 的

    #region ImageFormat 1~255 值用于图片类型

    /// <inheritdoc cref="ImageFormat.BMP"/>
    BMP = ImageFormat.BMP,

    /// <inheritdoc cref="ImageFormat.GIF"/>
    GIF = ImageFormat.GIF,

    /// <inheritdoc cref="ImageFormat.ICO"/>
    ICO = ImageFormat.ICO,

    /// <inheritdoc cref="ImageFormat.JPEG"/>
    JPEG = ImageFormat.JPEG,

    /// <inheritdoc cref="ImageFormat.PNG"/>
    PNG = ImageFormat.PNG,

    /// <inheritdoc cref="ImageFormat.WebP"/>
    WebP = ImageFormat.WebP,

    /// <inheritdoc cref="ImageFormat.HEIF"/>
    HEIF = ImageFormat.HEIF,

    /// <inheritdoc cref="ImageFormat.HEIFSequence"/>
    HEIFSequence = ImageFormat.HEIFSequence,

    /// <inheritdoc cref="ImageFormat.HEIC"/>
    HEIC = ImageFormat.HEIC,

    /// <inheritdoc cref="ImageFormat.HEICSequence"/>
    HEICSequence = ImageFormat.HEICSequence,

    #endregion

    #region 256~xxx 待定

    /// <summary>
    /// .exe
    /// </summary>
    WinExe = 256,

    /// <summary>
    /// .tar.gz
    /// </summary>
    TarGzip,

    /// <summary>
    /// .7z
    /// </summary>
    SevenZip,

    /// <summary>
    /// .tar.br
    /// </summary>
    TarBrotli,

    /// <summary>
    /// .tar.xz
    /// </summary>
    TarXz,

    /// <summary>
    /// .tar.zst
    /// </summary>
    TarZstd,

    /// <summary>
    /// .dmg
    /// </summary>
    DMG,

    /// <summary>
    /// .deb
    /// </summary>
    DEB,

    /// <summary>
    /// .rpm
    /// </summary>
    RPM,

    /// <summary>
    /// .apk
    /// </summary>
    APK,

    #endregion

    /// <summary>
    /// .json
    /// </summary>
    Json = 300,

    /// <summary>
    /// .dll
    /// </summary>
    Dll,

    /// <summary>
    /// .xml
    /// </summary>
    Xml,

    /// <summary>
    /// .so
    /// </summary>
    So,

    /// <summary>
    /// .dylib
    /// </summary>
    Dylib,

    /// <summary>
    /// 无
    /// </summary>
    None,

    /// <summary>
    /// .js
    /// </summary>
    Js,

    /// <summary>
    /// .xaml
    /// </summary>
    Xaml,

    /// <summary>
    /// .axaml
    /// </summary>
    AXaml,

    /// <summary>
    /// .cs
    /// </summary>
    CSharp,

    /// <summary>
    /// .msix
    /// </summary>
    Msix = 901,

    /// <summary>
    /// .msixupload
    /// </summary>
    MsixUpload,
}

/// <summary>
/// Enum 扩展 <see cref="CloudFileType"/>
/// </summary>
public static partial class CloudFileTypeEnumExtensions
{
    /// <summary>
    /// 将 <see cref="CloudFileType"/> 转换为 <see cref="ImageFormat"/>，值不为图片类型时将返回默认值
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public static ImageFormat GetImageFormat(this CloudFileType type)
    {
        var value = Enum2.ConvertToInt32(type);
        if (value > 0 && value < byte.MaxValue)
        {
            var value2 = Convert.ToByte(value);
            return (ImageFormat)value2;
        }
        return default;
    }

    /// <summary>
    /// 扩展名或者图片类型识别是否是支持的文件类型
    /// </summary>
    /// <param name="extension"></param>
    /// <param name="imageFormat"></param>
    /// <returns></returns>
    public static CloudFileType? GetFileFormat(this string extension, ImageFormat? imageFormat)
    {
        if (imageFormat.HasValue)
        {
            var value = Enum2.ConvertToInt32(imageFormat.Value);
            if (value > 0 && value < byte.MaxValue)
            {
                var value2 = Convert.ToByte(value);
                return (CloudFileType)value2;
            }
        }
        else
            return extension.ToLower() switch
            {
                FileEx.EXE => (CloudFileType?)CloudFileType.WinExe,
                ".tar.gz" or FileEx.TAR_GZ => (CloudFileType?)CloudFileType.TarGzip,
                FileEx.TAR_XZ => (CloudFileType?)CloudFileType.TarXz,
                FileEx.TAR_ZST => (CloudFileType?)CloudFileType.TarZstd,
                FileEx.DMG => (CloudFileType?)CloudFileType.DMG,
                FileEx.DEB => (CloudFileType?)CloudFileType.DEB,
                FileEx.RPM => (CloudFileType?)CloudFileType.RPM,
                FileEx.APK => (CloudFileType?)CloudFileType.RPM,
                _ => null,
            };
        return null;
    }
}