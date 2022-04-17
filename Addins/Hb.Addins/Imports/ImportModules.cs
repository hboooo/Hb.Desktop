using Hb.Addins.IModules;
using System;

namespace Hb.Addins.Imports
{
    public class ImportModules : ImportBase<ImportModuleCollection, IModule, IModuleMetaData>
    {
        public override string[] Dirs { get; set; } = new string[] { "Modules" };

    }
}
