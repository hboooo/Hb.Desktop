namespace Hb.Addins.IAddins
{
    /// <summary>
    /// 插件系统
    /// 所有插件、第三方接入通过实现此接口与系统隔离
    /// </summary>
    public interface IPlugin
    {
        IContext Context { get; set; }
        /// <summary>
        /// 系统初始化完成后
        /// </summary>
        /// <param name="objs"></param>
        /// <returns></returns>
        bool Initialized(params object[] objs);
        /// <summary>
        /// 主窗口打开后
        /// </summary>
        /// <param name="objs"></param>
        /// <returns></returns>
        bool MainWindowInited(params object[] objs);
        /// <summary>
        /// 释放资源
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        bool Disponse(object obj);
    }
}
