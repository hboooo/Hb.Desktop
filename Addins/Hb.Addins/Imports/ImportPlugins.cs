using Hb.Addins.IAddins;
using System;

namespace Hb.Addins.Imports
{
    public class ImportPlugins: ImportBase<ImportPluginCollection, IPlugin, IPluginMetaData>
    {
        public override string[] Dirs { get; set; } = new string[] { "Addins" };

    }
}
