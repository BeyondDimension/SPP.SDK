namespace Mobius.Enums.App;

#if DEBUG
/// <summary>
/// 应用程序的路由/终结点/页面/窗口
/// </summary>
[Obsolete("使用导航路由，此枚举作废", true)]
public enum AppEndPoint : byte
{
    /// <summary>
    /// 登录或注册
    /// </summary>
    LoginOrRegister = 1,

    /// <summary>
    /// 消息框
    /// </summary>
    MessageBox,

    /// <summary>
    /// 添加令牌
    /// </summary>
    AddAuth,

    /// <summary>
    /// 显示令牌详情
    /// </summary>
    ShowAuth,

    /// <summary>
    /// Steam 令牌交易确认
    /// </summary>
    AuthTrade,

    /// <summary>
    /// 加密令牌
    /// </summary>
    EncryptionAuth,

    /// <summary>
    /// 文本框
    /// </summary>
    TextBox,

    /// <summary>
    /// 任务栏
    /// </summary>
    TaskBar,

    /// <summary>
    /// 导出令牌
    /// </summary>
    ExportAuth,

    /// <summary>
    /// 脚本商店
    /// </summary>
    ScriptStore,

    /// <summary>
    /// 隐藏游戏
    /// </summary>
    HideApp,

    /// <summary>
    /// 编辑游戏信息
    /// </summary>
    EditAppInfo,

    /// <summary>
    /// 挂卡游戏列表
    /// </summary>
    IdleApp,

    /// <summary>
    /// 分享管理
    /// </summary>
    ShareManage,

    /// <summary>
    /// 换绑手机号码
    /// </summary>
    [Obsolete("use web")]
    ChangeBindPhoneNumber,

    /// <summary>
    /// 用户个人资料
    /// </summary>
    UserProfile,

    /// <summary>
    /// 新版本
    /// </summary>
    [Obsolete("not impl", true)]
    NewVersion,

    /// <summary>
    /// 绑定手机号码
    /// </summary>
    [Obsolete("use web")]
    BindPhoneNumber,

    /// <summary>
    /// 添加 ASF Bot
    /// </summary>
    ASF_AddBot,

    /// <summary>
    /// Steam 关闭
    /// </summary>
    SteamShutdown,

    /// <summary>
    /// 代理设置
    /// </summary>
    ProxySettings,

    /// <summary>
    /// 通知
    /// </summary>
    Notice,

    /// <summary>
    /// 保存编辑的游戏信息
    /// </summary>
    SaveEditedAppInfo,

    /// <summary>
    /// 内容
    /// </summary>
    Content,
}

[Obsolete("use AppEndPoint", true)]
public enum CustomWindow { }
#endif