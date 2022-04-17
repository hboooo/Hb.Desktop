using System.ComponentModel;

namespace Hb
{
    /// <summary>
    /// 操作类型
    /// </summary>
    public enum ActionID
    {
        [Description("")]
        UnKnow = 0,
        /// <summary>
        /// 添加
        /// </summary>
        [Description("添加")]
        Add = 1,
        /// <summary>
        /// 编辑
        /// </summary>
        [Description("编辑")]
        Edit,
        /// <summary>
        /// 删除
        /// </summary>
        [Description("删除")]
        Delete,
        /// <summary>
        /// 查看
        /// </summary>
        [Description("查看")]
        View,
        /// <summary>
        /// 登录
        /// </summary>
        [Description("登录")]
        LogIn,
        /// <summary>
        /// 注销
        /// </summary>
        [Description("注销")]
        LogOut,
        /// <summary>
        /// 视频播放
        /// </summary>
        [Description("视频播放")]
        PlayVideo,
        /// <summary>
        /// 视频停止
        /// </summary>
        [Description("视频停止")]
        StopVideo,
        /// <summary>
        /// 权限同步
        /// </summary>
        [Description("权限同步")]
        AuthSync,
        /// <summary>
        /// 查看权限
        /// </summary>
        [Description("查看权限")]
        ViewAuth,
    }
}
