namespace Mobius.Models.Abstractions;

/// <summary>
/// 设备标识符
/// </summary>
public interface IDeviceId
{
    /// <summary>
    /// 设备标识符 G
    /// </summary>
    Guid DeviceIdG { get; set; }

    /// <summary>
    /// 设备标识符 R
    /// </summary>
    string? DeviceIdR { get; set; }

    /// <summary>
    /// 设备标识符 N
    /// </summary>
    string? DeviceIdN { get; set; }
}