using System.ComponentModel;

namespace Hb
{
    /// <summary>
    /// 设备在线状态
    /// </summary>
    public enum OnlineStatus
    {
        [Description("离线")]
        Off = 0,
        [Description("在线")]
        On = 1
    }
}
