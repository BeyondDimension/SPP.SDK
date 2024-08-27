namespace Mobius.Models.Shop.Response;

public class WeiChatPayResponse
{
    public WeChatPayUnifiedOrderResponse? Response { get; set; }

    public string? PaymentId { get; set; }
}
