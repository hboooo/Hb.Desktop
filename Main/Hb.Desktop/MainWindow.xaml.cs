using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hb.Desktop
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.IsVisibleChanged += MainWindow_IsVisibleChanged;
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.Loaded -= MainWindow_Loaded;

            var moduleParts = DesktopMain.MainApp.AppStartup.ImportModules.Parts;
            if (moduleParts != null && moduleParts.Items != null && moduleParts.Items.Count() > 0)
            {
                var sorted = moduleParts.Items.OrderBy(m => m.Metadata.Index);
                foreach (var item in sorted)
                {
                    Logger.DebugFormatted("Modules initialized, {0}", item.Metadata.Name);
                    tabControl.Items.Add(new TabItem() { Header = item.Metadata.Name, Content = item.Value.CreateView() });
                }
            }

            var addinParts = DesktopMain.MainApp.AppStartup.ImportAddins.Parts;
            if (addinParts != null && addinParts.Items != null && addinParts.Items.Count() > 0)
            {
                var sorted = addinParts.Items.OrderBy(m => m.Metadata.Index);
                foreach (var item in sorted)
                {

                    Logger.DebugFormatted("Plugins initialized, {0}", item.Metadata.Name);
                    item.Value.Initialized(item.Metadata.Name);
                }
            }
        }

        private void MainWindow_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (sender is Window win && win.Visibility == Visibility.Visible)
            {
                this.IsVisibleChanged -= MainWindow_IsVisibleChanged;
                CloseSplashScreen();
            }
        }

        private void CloseSplashScreen()
        {
            if (SplashScreenWindow.SplashScreen != null)
            {
                Logger.Debug("Close splashScreen");
                SplashScreenWindow.SplashScreen.Dispatcher.Invoke(new Action(() => { SplashScreenWindow.SplashScreen.Close(); }));
                SplashScreenWindow.SplashScreen = null;
            }
        }
    }
}
