using Hb;
using Hb.Addins.IModules;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Hb.Desktop.Modules.Ink
{
    [Export(typeof(IModule))]
    [Module(ModuleType = ModuleId.Main_Module_Ink, Index = (int)ModuleId.Main_Module_Ink, Name = "画板")]
    public class InkModule : ModuleBase<InkView, InkViewModel>
    {

    }
}
