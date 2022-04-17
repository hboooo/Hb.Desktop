using System;
using System.ComponentModel.Composition;

namespace Hb.Addins.IAddins
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class PluginAttribute : ExportAttribute, IPluginMetaData
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public int Index { get; set; }

        public string Name { get; set; }

        public object Tag { get; set; }

        public ImportType ImportType { get; private set; } = ImportType.Addin;

    }
}
