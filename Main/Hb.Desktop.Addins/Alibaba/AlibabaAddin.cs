using Hb.Addins.IAddins;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hb.Desktop.Addins.Alibaba
{
    /// <summary>
    /// author     :habo
    /// date       :2022/4/17 22:48:06
    /// description:
    /// </summary>
    [Export(typeof(IPlugin))]
    [Plugin(Name = "阿里巴巴", Index = 3, Id = "Alibaba")]
    internal class AlibabaAddin : IPlugin
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
