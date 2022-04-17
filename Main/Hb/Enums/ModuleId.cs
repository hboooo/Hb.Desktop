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

        #region 系统菜单
        /// <summary>
        /// 系统菜单
        /// </summary>
        Main_Module = 0x0100000,
        #endregion

        /// <summary>
        /// 预览
        /// </summary>
        [Description("预览")]
        Main_Module_Home = Main_Module | 0x1000,
        /// <summary>
        /// 基础/资料
        /// </summary>
        //[Description("资源")]
        //Main_Module_Basics = Main_Module | 0x2000,
        /// <summary>
        /// 设置
        /// </summary>
        [Description("设置")]
        Main_Module_Option = Main_Module | 0x3000,
        /// <summary>
        /// 设置/系统设置
        /// </summary>
        [Description("系统设置")]
        Main_Module_Option_System = Main_Module_Option | 0x01,
        /// <summary>
        /// 设置/设备设置
        /// </summary>
        [Description("设备设置")]
        Main_Module_Option_Device = Main_Module_Option | 0x02,
        /// <summary>
        /// 设置/操作日志
        /// </summary>
        [Description("操作日志")]
        Main_Module_Option_Log = Main_Module_Option | 0x03,
    }
}
