using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Hb.Core
{
    /// <summary>
    /// 容器组装
    /// </summary>
    public class CoreComposition
    {
        public static CompositionContainer ExportComposition(Assembly assembly)
        {
            try
            {
                var catalog = new AssemblyCatalog(assembly);
                CompositionContainer compositionContainer = new CompositionContainer(catalog);
                compositionContainer.ComposeParts(typeof(CoreComposition));
                return compositionContainer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }
    }
}
