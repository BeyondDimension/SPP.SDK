namespace Mobius.Models.Basics;

/// <summary>
/// 应用程序版本下载模型
/// </summary>
[MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial class AppVersionDownloadModel : IExplicitHasValue
{
    /// <inheritdoc cref="CloudFileType"/>
    [MP2Key(0)]
    public CloudFileType DownloadType { get; set; }

    /// <inheritdoc cref="System.Security.Cryptography.SHA256"/>
    [MP2Key(1)]
    public string? SHA256 { get; set; }

    /// <summary>
    /// 文件大小
    /// </summary>
    [MP2Key(2)]
    public long Length { get; set; }

    /// <summary>
    /// 下载地址
    /// </summary>
    [MP2Key(3)]
    public string DownloadUrl { get; set; } = "";

    /// <inheritdoc cref="UpdateChannelType"/>
    [MP2Key(4)]
    public UpdateChannelType DownloadChannelType { get; set; }

    /// <inheritdoc cref="System.Security.Cryptography.SHA384"/>
    [MP2Key(5)]
    public string? SHA384 { get; set; }

    /// <inheritdoc/>
    bool IExplicitHasValue.ExplicitHasValue()
    {
        return ((SHA256 != null && SHA256.Length == Hashs.String.Lengths.SHA256) || (SHA384 != null && SHA384.Length == Hashs.String.Lengths.SHA384)) &&
            String2.IsHttpUrl(DownloadUrl, true) &&
            Length > 0 &&
            DownloadType.IsDefined() &&
            DownloadChannelType != UpdateChannelType.Auto && DownloadChannelType.IsDefined();
    }
}
