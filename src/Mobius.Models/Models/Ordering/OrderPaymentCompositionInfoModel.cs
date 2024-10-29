namespace Mobius.Models.Ordering;

public class OrderPaymentCompositionInfoModel
{
    /// <summary>
    /// 支付方式
    /// </summary>
    public PaymentMethod PaymentMethod { get; set; }

    /// <summary>
    /// 支付类型
    /// </summary>
    public PaymentType PaymentType { get; set; }

    /// <summary>
    /// 用户优惠劵信息
    /// </summary>
    public UserCouponInfoModel? UserCouponInfo { get; set; }

    /// <summary>
    /// 支付金额
    /// </summary>
    public decimal PaymentAmount { get; set; }

    public string? Remarks { get; set; }
}