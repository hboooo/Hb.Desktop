using System;
using System.ComponentModel.Composition;

namespace Hb.Addins.IModules
{

    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ModuleAttribute : ExportAttribute, IModuleMetaData
    {
        public string Id { get; private set; } = Guid.NewGuid().ToString();

        public ModuleId ModuleType { get; set; }

        public int Index { get; set; }

        public string Name { get; set; }

        public ImportType ImportType { get; private set; } = ImportType.Module;
    }
}
