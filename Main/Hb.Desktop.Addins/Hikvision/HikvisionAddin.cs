using Hb.Addins.IAddins;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hb.Desktop.Addins.Hikvision
{
    /// <summary>
    /// author     :habo
    /// date       :2022/4/17 22:48:16
    /// description:
    /// </summary>
    [Export(typeof(IPlugin))]
    [Plugin(Name = "海康威视", Index = 2, Id = "Hikvision")]
    internal class HikvisionAddin : IPlugin
    {
        public IContext Context { get; set; }

        public bool Disponse(object obj)
        {
            return true;
        }

        public bool Initialized(params object[] objs)
        {
            return true;
        }

        public bool MainWindowInited(params object[] objs)
        {
            return true;
        }
    }
}
