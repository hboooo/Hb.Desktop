using System.ComponentModel;

namespace Hb
{
    /// <summary>
    /// 告警类型
    /// </summary>
    public enum AlarmType
    {
        /// <summary>
        /// 操作超时
        /// </summary>
        [Description("长时间未操作，系统已锁定")]
        OperatorTimeout = 1,
        /// <summary>
        /// 连接服务失败
        /// </summary>
        [Description("连接服务失败，请检查网络")]
        ConnectToServerFaied = 2,
        /// <summary>
        /// 磁盘空间不足
        /// </summary>
        [Description("磁盘空间不足")]
        DiskSpaceFull = 3,
        /// <summary>
        /// 所在的项目设备已全部到期
        /// </summary>
        [Description("所在的项目设备已全部到期")]
        ServiceChargeExpired = 4,
        /// <summary>
        /// 所在的项目部分设备已到期
        /// </summary>
        [Description("所在的项目部分设备已到期")]
        ServiceChargePartExpired = 5,
        /// <summary>
        /// 所在的项目有设备即将到期
        /// </summary>
        [Description("所在的项目有设备即将到期")]
        ServiceChargeWillExpire = 6,
    }
}
