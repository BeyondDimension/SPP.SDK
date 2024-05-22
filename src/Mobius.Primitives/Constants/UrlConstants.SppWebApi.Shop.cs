namespace Mobius.Constants;

partial class UrlConstants // 游戏商城
{
    /// <summary>
    /// 商城商品详情网址
    /// </summary>
    public static string WattGame_Goods_Detail_ => $"{WattGame}/goods/detail/{{0}}";

    /// <summary>
    /// 商城 Web 登录
    /// </summary>
    public static string WattGame_Web_Login_ => $"{WattGame}/oauth/verifier?tk={{0}}&t={{1}}&to={{2}}";
}