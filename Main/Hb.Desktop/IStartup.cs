using Hb.Addins.Imports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hb.Desktop
{
    /// <summary>
    /// author     :habo
    /// date       :2022/4/17 19:52:49
    /// description:
    /// </summary>
    public interface IStartup
    {
        ImportModules ImportModules { get; }
        ImportPlugins ImportAddins { get; }

        void Initialize();

        bool InstallModules();

        bool InstallAddins();

        void Release();
    }
}
