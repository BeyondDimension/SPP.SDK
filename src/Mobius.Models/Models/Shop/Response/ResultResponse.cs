namespace Mobius.Models.Shop.Response;

public class ResultResponse<TData, TOtherData>
{
    public TData? Data { get; set; }

    public TOtherData? OtherData { get; set; }
}