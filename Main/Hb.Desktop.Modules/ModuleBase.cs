using Hb.Addins;
using Hb.Addins.IModules;
using Hb.Addins.IViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hb.Desktop.Modules
{
    /// <summary>
    /// author     :habo
    /// date       :2022/4/17 21:38:11
    /// description:
    /// </summary>
    public class ModuleBase<V, VM> : IModule
        where V : IView, new()
        where VM : IViewModel, new()
    {

        public IView CreateView()
        {
            var view = new V();
            SetValue(view, CreateViewModel());
            return view;
        }


        public IViewModel CreateViewModel()
        {
            return MvvmFactory.Create<VM>();
        }


        private void SetValue(V v, object obj)
        {
            var propertyInfo = v.GetType().GetProperty("DataContext");
            if (propertyInfo != null)
            {
                propertyInfo.SetValue(v, obj, null);
            }
        }
    }
}
