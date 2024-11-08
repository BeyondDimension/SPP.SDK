namespace Mobius.Models.SteamRecharge;

/// <summary>
/// 批量创建 产品密钥 请求
/// </summary>
[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial record BatchCreateProductKeyRecordRequest
{
    /// <summary>
    /// 充值物品id
    /// </summary>
    [MPKey(0), MP2Key(0)]
    public Guid GoodsRechargeCategoryId { get; set; }

    /// <summary>
    /// 批量创建数量
    /// </summary>
    [MPKey(1), MP2Key(1)]
    [Required(ErrorMessage = "充值数量错误")]
    public int Count { get; set; }

    /// <summary>
    /// 充值物品面额
    /// </summary>
    [MPKey(2), MP2Key(2)]
    [Required(ErrorMessage = "充值面额错误")]
    public decimal Amount { get; set; }

    [MPKey(3), MP2Key(3)]
    public Guid? CreateUserId { get; set; }
}