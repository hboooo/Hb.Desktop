using System.ComponentModel;

namespace Hb
{
    /// <summary>
    /// 告警等级
    /// </summary>
    public enum AlarmLevel
    {
        /// <summary>
        /// 提示告警
        /// </summary>
        [Description("提示告警")]
        Info,
        /// <summary>
        /// 一般告警
        /// </summary>
        [Description("一般告警")]
        Normal,
        /// <summary>
        /// 重要告警
        /// </summary>
        [Description("重要告警")]
        Import,
        /// <summary>
        /// 紧急告警
        /// </summary>
        [Description("紧急告警")]
        Urgency,
    }
}
