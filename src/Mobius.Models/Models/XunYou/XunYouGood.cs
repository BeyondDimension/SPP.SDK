// ReSharper disable once CheckNamespace

namespace Mobius.Models.XunYou;

[MP2Obj(GenerateType.VersionTolerant, MP2SerializeLayout.Explicit)]
public partial class XunYouGoodDTO
{
    /// <summary>
    /// Id
    /// </summary>
    [MP2Key(0)]
    public Guid Id { get; set; }

    /// <summary>
    /// 商品名
    /// </summary>
    [MP2Key(1)]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 价格
    /// </summary>
    [MP2Key(2)]
    public decimal Price { get; set; }

    /// <summary>
    /// 首次价格
    /// </summary>
    [MP2Key(3)]
    public decimal? FirstPrice { get; set; }

    /// <summary>
    /// 充值天数
    /// </summary>
    [MP2Key(4)]
    public int RechargeDays { get; set; }

    /// <summary>
    /// 是否协议商品（自动扣款续费）
    /// </summary>
    [MP2Key(5)]
    public bool IsAgreement { get; set; }
}