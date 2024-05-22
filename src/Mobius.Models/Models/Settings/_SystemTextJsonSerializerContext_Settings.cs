namespace Mobius.Models.Settings;

/// <summary>
/// 设置项模型的 Json 源生成
/// </summary>
[JsonSerializable(typeof(UISettingsModel))]
[JsonSerializable(typeof(AppTheme))]
[JsonSerializable(typeof(MBDontPromptType))]
[JsonSerializable(typeof(WindowBackgroundMaterial))]
[JsonSerializable(typeof(XamlMediaStretch))]
[JsonSerializable(typeof(GeneralSettingsModel))]
[JsonSerializable(typeof(UpdateChannelType))]
[JsonSerializable(typeof(TextReaderProvider))]
[JsonSerializable(typeof(EncodingType))]
[JsonSourceGenerationOptions(
    DefaultIgnoreCondition = SystemTextJsonIgnoreCondition.Never,
    IgnoreReadOnlyFields = false,
    IgnoreReadOnlyProperties = true,
    IncludeFields = false,
    WriteIndented = true,
    UseStringEnumConverter = true,
    AllowTrailingCommas = true)]
public sealed partial class SystemTextJsonSerializerContext_Settings : SystemTextJsonSerializerContext
{
}
