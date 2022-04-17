using System.ComponentModel;

namespace Hb
{
    /// <summary>
    /// 访问类型
    /// </summary>
    public enum HouseholdType : int
    {
        /// <summary>
        /// 访客
        /// </summary>
        [Description("访客")]
        Visitor = 4,
        /// <summary>
        /// 业主
        /// </summary>
        [Description("业主")]
        Owner = 5,
        /// <summary>
        /// VIP
        /// </summary>
        [Description("VIP")]
        VIP = 6,
    }
}
