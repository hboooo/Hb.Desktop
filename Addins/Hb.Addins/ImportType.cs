using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hb.Addins
{
    /// <summary>
    /// 模块类型
    /// </summary>
    public enum ImportType
    {
        None = 0,
        /// <summary>
        /// 子模块，如子系统
        /// </summary>
        Module = 1,
        /// <summary>
        /// 扩展，如插件，第三方接入等
        /// </summary>
        Addin = 2
    }
}
