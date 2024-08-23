namespace Mobius.Models.Shop.Request;

public class GoodsDetailRequest
{
    /// <summary>
    ///     序列
    /// </summary>
    [SystemTextJsonProperty("productId")]
    public int? ProductId { get; set; }

    [SystemTextJsonProperty("id")]
    public int Id { get; set; }

    [SystemTextJsonProperty("data")]
    public object? Data { get; set; }
}
