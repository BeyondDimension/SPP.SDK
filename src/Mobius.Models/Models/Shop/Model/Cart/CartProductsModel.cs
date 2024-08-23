namespace Mobius.Models.Shop;

public class CartProductsModel
{
    [JsonPropertyName("id")]
    public int Id { get; set; } = 0;

    [JsonPropertyName("userId")]
    public int UserId { get; set; } = 0;

    [JsonPropertyName("productId")]
    public int ProductId { get; set; } = 0;

    [JsonPropertyName("nums")]
    public int Nums { get; set; } = 1;

    [JsonPropertyName("isCollection")]
    public bool IsCollection { get; set; } = false;

    [JsonPropertyName("isSelect")]
    public bool IsSelect { get; set; } = false;

    [JsonPropertyName("type")]
    public int Type { get; set; } = 1;

    [JsonPropertyName("weight")]
    public decimal Weight { get; set; } = 0;

    [JsonPropertyName("products")]
    public CoreCmsProductsModel Products { get; set; } = new();

    [JsonPropertyName("good")]
    public CoreCmsGoodsModel? Good { get; set; }
}
