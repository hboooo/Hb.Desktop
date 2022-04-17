using Hb.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Hb.Desktop
{
    /// <summary>
    /// author     :habo
    /// date       :2022/4/17 19:55:48
    /// description:
    /// </summary>
    static class DesktopMain
    {
        public static App MainApp;

        [STAThread]
        public static void Main(string[] args)
        {
            try
            {
                bool autorun = IsAutorun(args);
                string appName = Assembly.GetExecutingAssembly().GetName().Name;
                Process proc = Utils.GetProcess(appName);
                Process current = Process.GetCurrentProcess();
                if (proc != null || proc.Id == current.Id)
                {
                    Mutex mutex = new Mutex(true, appName, out bool run);
                    if (run)
                    {
                        mutex.ReleaseMutex();
                        ApplicationRun(autorun);
                    }
                    else
                    {
                        Native.SwitchToThisWindow(proc.MainWindowHandle, true);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }
        }

        static void ApplicationRun(bool autorun = true)
        {
            try
            {
                SplashScreenWindow.ShowSplashScreen();
                IStartup startup = new Startup();
                MainApp = new App(startup);
                InitAsync(startup);
                MainApp.Run(new MainWindow());
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }
        }

        static void InitAsync(IStartup startup)
        {
            var task = Task.Run(() =>
            {
                try
                {
                    startup.Initialize();
                    startup.InstallModules();
                    startup.InstallAddins();
                    Thread.Sleep(2000);
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                }
            });
            Desk.Wait(task);
        }

        static bool IsAutorun(string[] args)
        {
            bool autorun = false;
            if (args != null && args.Length > 0)
            {
                string[] strArgs = Environment.GetCommandLineArgs();
                if (strArgs.Length >= 2 && strArgs[1].Equals("-autorun"))
                    autorun = true;
            }
            return autorun;
        }
    }
}
