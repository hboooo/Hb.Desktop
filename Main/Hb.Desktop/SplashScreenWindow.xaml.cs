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
using System.Windows.Shapes;

namespace Hb.Desktop
{
    /// <summary>
    /// SplashScreenWindow.xaml 的交互逻辑
    /// </summary>
    public partial class SplashScreenWindow : Window
    {
        public SplashScreenWindow()
        {
            InitializeComponent();
        }

        static SplashScreenWindow splashScreen;

        public static SplashScreenWindow SplashScreen
        {
            get
            {
                return splashScreen;
            }
            set
            {
                splashScreen = value;
            }
        }

        public static void ShowSplashScreen()
        {
            splashScreen = new SplashScreenWindow();
            splashScreen.Show();
        }

        public void UpdateProgressText(string text)
        {
            this.txtSplashText.Text = text;
        }
    }
}
