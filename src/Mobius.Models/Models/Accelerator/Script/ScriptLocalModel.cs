namespace Mobius.Models.Accelerator.Script;

/// <summary>
/// 脚本本地模型
/// </summary>
[MPObj, MP2Obj(MP2SerializeLayout.Explicit)]
public sealed partial class ScriptLocalModel : JsonModel<ScriptLocalModel>, IDescribe
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

    string? mMatchDomainNames = string.Empty;
    Lazy<string[]>? lazyMatchDomainNames;

    /// <summary>
    /// 匹配域名
    /// </summary>
    [MPKey(7), MP2Key(7)]
    public string? MatchDomainNames
    {
        get => mMatchDomainNames;
        set
        {
            if (mMatchDomainNames == value)
                return;

            mMatchDomainNames = value;
            if (string.IsNullOrWhiteSpace(mMatchDomainNames))
                lazyMatchDomainNames = null;
            else
                lazyMatchDomainNames = new(() => ApiConstants.GetSplitValues(mMatchDomainNames));
        }
    }

    /// <summary>
    /// 匹配域名数组
    /// </summary>
    [XmlIgnore, IgnoreDataMember, SystemTextJsonIgnore, NewtonsoftJsonIgnore, MPIgnore, MP2Ignore]
    public string[] MatchDomainNamesArray => lazyMatchDomainNames == null ? [] : lazyMatchDomainNames.Value;

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

    string? mExcludeDomainNames = string.Empty;
    Lazy<string[]>? lazyExcludeDomainNames;

    /// <summary>
    /// 排除域名，分号分割多个
    /// </summary>
    [MPKey(11), MP2Key(11)]
    public string? ExcludeDomainNames
    {
        get => mExcludeDomainNames;
        set
        {
            if (mExcludeDomainNames == value)
                return;

            mExcludeDomainNames = value;
            if (string.IsNullOrWhiteSpace(mExcludeDomainNames))
                lazyExcludeDomainNames = null;
            else
                lazyExcludeDomainNames = new(() => ApiConstants.GetSplitValues(mExcludeDomainNames));
        }
    }

    /// <summary>
    /// 排除域名数组
    /// </summary>
    [XmlIgnore, IgnoreDataMember, SystemTextJsonIgnore, NewtonsoftJsonIgnore, MPIgnore, MP2Ignore]
    public string[] ExcludeDomainNamesArray => lazyExcludeDomainNames == null ? [] : lazyExcludeDomainNames.Value;

    /// <summary>
    /// 关联的加速项目 Id
    /// </summary>
    [MPKey(12), MP2Key(12)]
    public List<Guid>? AccelerateProjects { get; set; }

    string? mRequiredJs = string.Empty;
    Lazy<string[]>? lazyRequiredJs;

    /// <summary>
    /// 依赖外部 JS，分号分割多个
    /// </summary>
    [MPKey(13), MP2Key(13)]
    public string? RequiredJs
    {
        get => mRequiredJs;
        set
        {
            if (mRequiredJs == value)
                return;

            mRequiredJs = value;
            if (string.IsNullOrWhiteSpace(mRequiredJs))
                lazyRequiredJs = null;
            else
                lazyRequiredJs = new(() => ApiConstants.GetSplitValues(mRequiredJs));
        }
    }

    /// <summary>
    /// 依赖外部 JS 数组
    /// </summary>
    [XmlIgnore, IgnoreDataMember, SystemTextJsonIgnore, NewtonsoftJsonIgnore, MPIgnore, MP2Ignore]
    public string[] RequiredJsArray => lazyRequiredJs == null ? [] : lazyRequiredJs.Value;

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

    /// <summary>
    /// 本地数据库 Id
    /// </summary>
    [MPKey(17), MP2Key(17)]
    public int LocalId { get; set; }

    /// <summary>
    /// 本地缓存路径
    /// </summary>
    [MPKey(18), MP2Key(18)]
    public string CachePath { get; set; } = string.Empty;

    /// <summary>
    /// 文件路径
    /// </summary>
    [MPKey(19), MP2Key(19)]
    public string FilePath { get; set; } = string.Empty;

    /// <summary>
    /// 文件名
    /// </summary>
    [XmlIgnore, IgnoreDataMember, SystemTextJsonIgnore, NewtonsoftJsonIgnore, MPIgnore, MP2Ignore]
    public string? FileName => string.IsNullOrWhiteSpace(FilePath) ? null : Path.GetFileName(FilePath);

    /// <summary>
    /// 更新时间
    /// </summary>
    [MPKey(20), MP2Key(20)]
    public DateTimeOffset? UpdateTime { get; set; }

    /// <summary>
    /// 是否为基础库
    /// </summary>
    [MPKey(21), MP2Key(21)]
    public bool IsBasics { get; set; } = false;
}

partial class ScriptLocalModel
{
    public static ScriptLocalModel Create(ScriptModel m)
    {
        var r = new ScriptLocalModel()
        {
            Name = m.Name,
            AuthorName = m.AuthorName,
            Version = m.Version,
            SourceLink = m.SourceLink,
            DownloadLink = m.DownloadLink,
            UpdateLink = m.UpdateLink,
            Describe = m.Describe,
            MatchDomainNames = m.MatchDomainNames,
            Disable = m.Disable,
            IconUrl = m.IconUrl,
            DependentGreasyForkFunction = m.DependentGreasyForkFunction,
            ExcludeDomainNames = m.ExcludeDomainNames,
            AccelerateProjects = m.AccelerateProjects,
            RequiredJs = m.RequiredJs,
            Id = m.Id,
            Order = m.Order,
            IsCompile = m.IsCompile,
        };
        return r;
    }
}