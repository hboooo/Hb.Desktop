using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hb.Addins.Imports
{
    /// <summary>
    /// author     :habo
    /// date       :2022/4/17 17:38:51
    /// description:
    /// </summary>
    public class ImportBase<TPart, T, TMetaData> where TPart : ImportCollection<T, TMetaData>, new()
    {
        public virtual string[] Dirs { get; set; }

        public CompositionContainer Container
        {
            get { return _container; }
        }


        private CompositionContainer _container;

        private TPart _composeParts;
        public TPart Parts
        {
            get { return _composeParts; }
        }

        /// <summary>
        /// 组装导入
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public virtual TPart Compose()
        {
            _composeParts = new TPart();
            using (DebugTimer.InfoTime($"Compose {typeof(TPart)} part"))
            {
                try
                {
                    var catalog = new AggregateCatalog();
                    foreach (var dir in Dirs)
                    {
                        if (Directory.Exists(dir))
                            catalog.Catalogs.Add(new DirectoryCatalog(dir));
                    }
                    _container = new CompositionContainer(catalog);
                    _container.ComposeParts(_composeParts);
                }
                catch (CompositionException compositionException)
                {
                    Logger.Fatal("Addins compose exception.", compositionException);
                }
                catch (Exception ex)
                {
                    Logger.Fatal("Addins compose Failed.", ex);
                }
            }

            return _composeParts;
        }

        /// <summary>
        /// 释放导入
        /// </summary>
        public virtual void Dispose()
        {
            using (DebugTimer.InfoTime($"Dispose part"))
            {
                _container.ReleaseExports(_composeParts.Items);
                _container.Dispose();
                _composeParts.Clear();
            }
        }
    }
}
