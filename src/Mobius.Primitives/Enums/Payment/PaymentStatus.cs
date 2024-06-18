namespace Mobius.Enums.Payment;

/// <summary>
/// 支付状态
/// </summary>
public enum PaymentStatus : byte
{
    [Description("待付款")]
    WaitPay = 0,

    [Description("已付款")]
    Paid = 1,

    [Description("已退款")]
    Refunded = 2,
}