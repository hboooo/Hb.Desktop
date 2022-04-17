using Hb.Addins.IModules;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Hb.Desktop.Modules.Option
{
    [Export(typeof(IModule))]
    [Module(ModuleType = ModuleId.Main_Module_Option, Index = (int)ModuleId.Main_Module_Option, Name = "设置")]
    public class OptionModule : ModuleBase<OptionView, OptionViewModel>
    {

    }
}
