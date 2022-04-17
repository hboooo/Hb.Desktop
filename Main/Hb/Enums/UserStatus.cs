using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Hb
{
    /// <summary>
    /// 同步用户状态
    /// </summary>
    public enum UserStatus
    {
        /// <summary>
        /// 正常
        /// </summary>
        [Description("正常")]
        Normal = 1,
        /// <summary>
        /// 禁用
        /// </summary>
        [Description("禁用")]
        Disabled = 2,
    }
}
