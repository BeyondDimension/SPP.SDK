namespace Mobius.Models.Accelerator.YarpConfig;

/// <inheritdoc cref="IResponseConfig"/>
[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial class ResponseConfig : JsonModel<ResponseConfig>, IResponseConfig
{
    /// <inheritdoc/>
    [MPKey(0), MP2Key(0)]
    public HttpStatusCode StatusCode { get; init; } = HttpStatusCode.OK;

    /// <inheritdoc/>
    [MPKey(1), MP2Key(1)]
    public string ContentType { get; init; } = "text/plain;charset=utf-8";

    /// <inheritdoc/>
    [MPKey(2), MP2Key(2)]
    public string? ContentValue { get; init; }
}