namespace Mobius.Models.Accelerator.Request;

/// <summary>
/// 获取加速项目分组请求
/// </summary>
[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial class GetAccelerateProjectGroupRequest
{
    /// <summary>
    /// 时间占位符
    /// </summary>
    [MPKey(0), MP2Key(0)]
    public DateTimeOffset DateTimeOffset { get; set; } = DateTimeOffset.UtcNow;

    /// <inheritdoc cref="KomaasharuType"/>
    [MPKey(1), MP2Key(1)]
    public KomaasharuType? ADType { get; set; }

    /// <inheritdoc cref="SppWebApiCompatDevicePlatform"/>
    [MPKey(2), MP2Key(2)]
#pragma warning disable CS0618 // 类型或成员已过时
    public SppWebApiCompatDevicePlatform Platform { get; set; }
#pragma warning restore CS0618 // 类型或成员已过时

    /// <inheritdoc cref="DeviceIdiom"/>
    [MPKey(3), MP2Key(3)]
    public DeviceIdiom DeviceIdiom { get; set; }

    /// <summary>
    /// 请求接口版本号
    /// </summary>
    [MPKey(4), MP2Key(4)]
    public byte Version { get; set; }
}
