using System.ComponentModel;

namespace Hb
{
    /// <summary>
    /// 系统模块、菜单定义
    /// </summary>
    public enum ModuleId
    {
        [Description("")]
        UnKnow = 0,

        /// <summary>
        /// 主页
        /// </summary>
        [Description("主页")]
        Main_Module_Home = 0x1000,
        /// <summary>
        /// 画板
        /// </summary>
        [Description("画板")]
        Main_Module_Ink = 0x2000,
        /// <summary>
        /// 设置
        /// </summary>
        [Description("设置")]
        Main_Module_Option = 0x3000,

    }
}
