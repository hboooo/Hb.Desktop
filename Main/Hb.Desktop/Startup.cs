using Hb.Addins.Imports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hb.Desktop
{
    /// <summary>
    /// author     :habo
    /// date       :2022/4/17 19:57:03
    /// description:
    /// </summary>
    internal class Startup : IStartup
    {
        ImportModules _importModules;
        ImportPlugins _importAddins;

        public ImportModules ImportModules => _importModules;

        public ImportPlugins ImportAddins => _importAddins;

        public void Initialize()
        {
            Logger.Initialize();

            Logger.Info($"*************** Version:     {Utils.GetReversion()}");
            Logger.Info($"*************** System:      {Utils.GetOperatingSystemInfo()}, x64:{Environment.Is64BitOperatingSystem}");
            Logger.Info($"*************** NET Version: {Environment.Version}");
            Logger.Info($"*************** Processor:   {Environment.ProcessorCount}");
            Logger.Info($"*************** Machine:     {Environment.MachineName}\\{Environment.UserName}");

            InitResource();
        }

        private void InitResource()
        {
            try
            {
                Application.Current.Resources.MergedDictionaries.Add((ResourceDictionary)(Application.LoadComponent(new Uri("/Hb.UI;component/Assets/UI.xaml", UriKind.RelativeOrAbsolute))));
                Application.Current.Resources.MergedDictionaries.Add((ResourceDictionary)(Application.LoadComponent(new Uri("/Hb.UI;component/Assets/UI.Light.xaml", UriKind.RelativeOrAbsolute))));
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }
        }

        public bool InstallModules()
        {
            try
            {
                _importModules = new ImportModules();
                _importModules.Compose();
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }
            return false;
        }

        public bool InstallAddins()
        {
            try
            {
                _importAddins = new ImportPlugins();
                _importAddins.Compose();
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }
            return false;
        }

        public void Release()
        {
            _importModules?.Dispose();
            _importAddins?.Dispose();
        }
    }
}
