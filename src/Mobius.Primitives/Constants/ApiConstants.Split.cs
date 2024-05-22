namespace Mobius.Constants;

partial class ApiConstants // Split 字符串分割
{
    /// <summary>
    /// 通用分隔符
    /// </summary>
    public const char GeneralSeparator = ';';

    /// <summary>
    /// 将字符串使用 <see cref="GeneralSeparator"/> 分割成数组
    /// </summary>
    /// <param name="values"></param>
    /// <returns></returns>
    public static string[] GetSplitValues(string? values)
    {
        if (string.IsNullOrWhiteSpace(values))
            return [];
        return values.Split(GeneralSeparator,
            StringSplitOptions.RemoveEmptyEntries);
    }
}