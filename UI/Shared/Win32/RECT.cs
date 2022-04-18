using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hb.UI.Win32
{
    /// <summary>
    /// author     :habo
    /// date       :2022/4/18 22:47:14
    /// description:
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int left, top, right, bottom;
    }
}
