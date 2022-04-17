using Hb;
using Hb.Addins.IModules;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Hb.Desktop.Modules.Home
{
    [Export(typeof(IModule))]
    [Module(ModuleType = ModuleId.Main_Module_Home, Index = (int)ModuleId.Main_Module_Home, Name = "主页")]
    public class HomeModule : ModuleBase<HomeView, HomeViewModel>
    {

    }
}
