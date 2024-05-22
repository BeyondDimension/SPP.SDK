namespace Mobius.Models.Drawing;

/// <summary>
/// 大小 Size(Width/Height)与位置 Position(X/Y)
/// </summary>
[MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial record class SizePositionModel
{
    /// <summary>
    /// 位置坐标：X
    /// </summary>
    [MP2Key(0)]
    public int X { get; set; }

    /// <summary>
    /// 位置坐标：Y
    /// </summary>
    [MP2Key(1)]
    public int Y { get; set; }

    /// <summary>
    /// 大小：高度
    /// </summary>
    [MP2Key(2)]
    public double Height { get; set; }

    /// <summary>
    /// 大小：宽度
    /// </summary>
    [MP2Key(3)]
    public double Width { get; set; }

    /// <inheritdoc />
    public override string ToString() => $"Size: {Width}x{Height}, Position: {X}x{Y}";
}
