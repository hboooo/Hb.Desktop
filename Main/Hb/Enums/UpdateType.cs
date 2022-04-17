using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hb
{
    /// <summary>
    /// 修改类型
    /// </summary>
    public enum UpdateType
    {
        UnKnow = 0,
        /// <summary>
        /// 添加
        /// </summary>
        Add = 1,
        /// <summary>
        /// 修改
        /// </summary>
        Update = 2,
        /// <summary>
        /// 删除
        /// </summary>
        Delete = 3,
    }
}
