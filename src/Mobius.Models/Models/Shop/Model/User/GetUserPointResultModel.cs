namespace Mobius.Models.Shop;

public class GetUserPointResultModel
{
    public int AvailablePoint { get; set; } = 0;

    public decimal PointExchangeMoney { get; set; } = 0;

    public bool Switch { get; set; } = true;

    public int Point { get; set; } = 0;
}
