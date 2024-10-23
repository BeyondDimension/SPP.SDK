namespace BD.WTTS.Models;

[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
public partial class OfficialMessageTypeModel
{
    /// <summary>
    /// 官方消息类型
    /// </summary>
    [MPKey(0), MP2Key(0)]
    public OfficialMessageType Type { get; set; }

    /// <summary>
    /// 类型名称
    /// </summary>
    [MPKey(1), MP2Key(1)]
    public string Name { get; set; } = string.Empty;
}
