using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hb.Addins.Imports
{
    /// <summary>
    /// author     :habo
    /// date       :2022/4/17 17:44:42
    /// description:
    /// </summary>
    public abstract class ImportCollection<T, TMetaData>
    {

        [ImportMany]
        public virtual IEnumerable<Lazy<T, TMetaData>> Items { get; set; }

        public virtual void Clear()
        {
            if (Items != null)
            {
                Items.ToList().Clear();
                Items = null;
            }
        }
    }
}
