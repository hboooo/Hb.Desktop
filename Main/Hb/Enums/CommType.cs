using System.ComponentModel;

namespace Hb
{
    /// <summary>
    /// 通讯模式
    /// 即云端或线下
    /// 云端http, 线下TCP/IP
    /// </summary>
    public enum CommType
    {
        [Description("未知")]
        None = 0,
        /// <summary>
        /// 旺龙云后台/云端HTTP
        /// </summary>
        [Description("云端通讯")]
        Cloud = 1,
        /// <summary>
        /// 局域网/线下平台/线下TCP/IP
        /// </summary>
        [Description("局域网通讯")]
        LAN = 2,
    }
}
