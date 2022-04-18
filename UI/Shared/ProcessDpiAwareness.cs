using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hb.UI
{
    /// <summary>
    /// author     :habo
    /// date       :2022/4/18 22:45:18
    /// description:Identifies dots per inch (dpi) awareness values.
    /// </summary>
    public enum ProcessDpiAwareness
    {
        /// <summary>
        /// Process is not DPI aware.
        /// </summary>
        DpiUnaware = 0,
        /// <summary>
        /// Process is system DPI aware (= WPF default).
        /// </summary>
        SystemDpiAware = 1,
        /// <summary>
        /// Process is per monitor DPI aware (Win81+ only).
        /// </summary>
        PerMonitorDpiAware = 2
    }
}
