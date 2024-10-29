namespace Mobius.Models.Payment;

/// <summary>
/// 订单业务支付方式
/// </summary>
public class OrderBusinessPaymentMethod
{
    /// <inheritdoc cref="Enums.Payment.PaymentMethod" />
    public PaymentMethod PaymentMethod { get; set; }

    /// <inheritdoc cref="Enums.Payment.PaymentType" />
    public PaymentType PaymentType { get; set; }
}