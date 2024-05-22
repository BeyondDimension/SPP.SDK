namespace Mobius.Enums.UI;

/// <summary>
/// 指定弹框是否可选不再显示。 用作 MessageBox.Show... 方法的参数。
/// </summary>
public enum MBDontPromptType
{
    /// <summary>
    /// 未定义
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// 解锁成就提示
    /// </summary>
    UnLockAchievement = 1,

    /// <summary>
    /// 赞助提示
    /// </summary>
    Donate = 2,

    /// <summary>
    /// 重置 Hosts 文件
    /// </summary>
    ResetHostsFile,

    /// <summary>
    /// 保存编辑的游戏信息
    /// </summary>
    SaveEditAppInfo,

    /// <summary>
    /// Android 证书信任提示
    /// </summary>
    AndroidCertificateTrustTip,

    /// <summary>
    /// 隐私政策
    /// </summary>
    Privacy,
}