using System.ComponentModel;

namespace Hb
{
    /// <summary>
    /// 控制器类型
    /// 云电梯、云群控器、云门禁、云联动器
    /// </summary>
    public enum ControllerType : int
    {
        /// <summary>
        /// 未知
        /// </summary>
        [Description("未知")]
        None = 0,
        /// <summary>
        /// 云电梯
        /// </summary>
        [Description("云电梯")]
        [DeviceProtocolType(0x21)]
        Elevator = 1,
        /// <summary>
        /// 云门禁
        /// </summary>
        [Description("云门禁")]
        [DeviceProtocolType(0x11)]
        Entrance = 2,
        /// <summary>
        /// 云群控器
        /// </summary>
        [Description("云群控器")]
        [DeviceProtocolType(0x80)]
        ClusterController = 3,
        /// <summary>
        /// 云联动器
        /// </summary>
        [Description("云联动器")]
        [DeviceProtocolType(0x16)]
        LinkageController = 4,
    }
}
