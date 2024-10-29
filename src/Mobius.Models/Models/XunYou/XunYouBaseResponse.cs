namespace Mobius.Models.XunYou;

[MP2Union(0, typeof(XunYouVipEndTimeResponse))]
[MPObj]
public abstract partial record class XunYouBaseResponse<TData> where TData : notnull
{
    [SystemTextJsonProperty("code")]
    [MPKey(0), MP2Key(0)]
    public XunYouBaseResponseCode Code { get; set; }

    /// <summary>
    /// 错误提示，报错时返回
    /// </summary>
    [SystemTextJsonProperty("message")]
    [MPKey(1), MP2Key(1)]
    public string? Message { get; set; }

    /// <summary>
    /// 返回数据
    /// </summary>
    [SystemTextJsonProperty("data")]
    [MPKey(2), MP2Key(2)]
    public TData? Data { get; set; }
}
