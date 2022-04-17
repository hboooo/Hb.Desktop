using Hb.Addins.IViews;

namespace Hb.Addins.IModules
{
    /// <summary>
    /// 模块化接口
    /// 系统子模块实现此接口
    /// </summary>
    public interface IModule
    {
        IView CreateView();

        IViewModel CreateViewModel();
    }
}
