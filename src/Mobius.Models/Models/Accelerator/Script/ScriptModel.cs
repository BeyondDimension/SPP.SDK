namespace Mobius.Models.Accelerator.Script;

/// <summary>
/// 脚本模型
/// </summary>
[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial class ScriptModel : JsonModel<ScriptModel>, IDescribe
{
    /// <summary>
    /// 显示名称
    /// </summary>
    [MPKey(0), MP2Key(0)]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 脚本作者
    /// </summary>
    [MPKey(1), MP2Key(1)]

    public string? AuthorName { get; set; }

    /// <summary>
    /// 版本号
    /// </summary>
    [MPKey(2), MP2Key(2)]
    public string Version { get; set; } = string.Empty;

    /// <summary>
    /// 源链接
    /// </summary>
    [MPKey(3), MP2Key(3)]
    public string SourceLink { get; set; } = string.Empty;

    /// <summary>
    /// 下载链接
    /// </summary>
    [MPKey(4), MP2Key(4)]
    public string DownloadLink { get; set; } = string.Empty;

    /// <summary>
    /// 更新链接
    /// </summary>
    [MPKey(5), MP2Key(5)]
    public string UpdateLink { get; set; } = string.Empty;

    /// <summary>
    /// 描述
    /// </summary>
    [MPKey(6), MP2Key(6)]
    public string? Describe { get; set; }

    /// <summary>
    /// 匹配域名
    /// </summary>
    [MPKey(7), MP2Key(7)]
    public string? MatchDomainNames { get; set; }

    /// <summary>
    /// 是否默认禁用
    /// </summary>
    [MPKey(8), MP2Key(8)]
    public bool Disable { get; set; }

    /// <summary>
    /// 脚本图标地址
    /// </summary>
    [MPKey(9), MP2Key(9)]
    public string? IconUrl { get; set; }

    /// <summary>
    /// 依赖油猴 GreasyFork 函数
    /// </summary>
    [MPKey(10), MP2Key(10)]
    public bool DependentGreasyForkFunction { get; set; }

    /// <summary>
    /// 排除域名，分号分割多个
    /// </summary>
    [MPKey(11), MP2Key(11)]
    public string? ExcludeDomainNames { get; set; }

    /// <summary>
    /// 关联的加速项目 Id
    /// </summary>
    [MPKey(12), MP2Key(12)]
    public List<Guid>? AccelerateProjects { get; set; }

    /// <summary>
    /// 依赖外部 JS，分号分割多个
    /// </summary>
    [MPKey(13), MP2Key(13)]
    public string? RequiredJs { get; set; }

    /// <summary>
    /// 脚本 Id
    /// </summary>
    [MPKey(14), MP2Key(14)]
    public Guid? Id { get; set; }

    /// <summary>
    /// 脚本排序值
    /// </summary>
    [MPKey(15), MP2Key(15)]
    public long Order { get; set; }

    /// <summary>
    /// 是否需要编译
    /// </summary>
    [MPKey(16), MP2Key(16)]
    public bool IsCompile { get; set; }
}