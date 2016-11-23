using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;

namespace ControlLibrary
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var con = SynchronizationContext.Current;
            System.Diagnostics.Debug.WriteLine("App:" + con.GetHashCode().ToString());


            this.Resources["test"] = "aaaa";
            this.Resources["solidcolorRed"] = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.AliceBlue);

            var str = this.Resources["test"] as string;

            var aliceblue = this.Resources["solidcolorRed"] as System.Windows.Media.SolidColorBrush;

            //throw new Exception("うい");
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }
    }
}
