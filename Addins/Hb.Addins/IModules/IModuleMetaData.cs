namespace Hb.Addins.IModules
{
    /// <summary>
    /// 模块化元数据
    /// </summary>
    public interface IModuleMetaData : IMetaData
    {
        ModuleId ModuleType { get; }
    }
}
