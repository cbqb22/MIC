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
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using MIC.Try.Common;
using System.Threading;


namespace ControlLibrary
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            TestMethod(5, "aaaa");

            this.Loaded += MainWindow_Loaded;

            var con = SynchronizationContext.Current;
            System.Diagnostics.Debug.WriteLine("Main:" + con.GetHashCode().ToString());

            ActionTest at = new ActionTest();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var b = AttachedProperty.GetIsCenter(this.label);
            var normalB = normal.BoolProperty;

            //AttachedProperty.SetIsCenter(this.label, true);
            //AttachedProperty.SetIsCenter(this.canvas, true);
        }

        public MainWindow(int i = 1)
        {
        }




        public static string GetTest(DependencyObject obj)
        {
            return (string)obj.GetValue(TestProperty);
        }

        public static void SetTest(DependencyObject obj, string value)
        {
            obj.SetValue(TestProperty, value);
        }

        // Using a DependencyProperty as the backing store for Test.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TestProperty =
            DependencyProperty.RegisterAttached("Test", typeof(string), typeof(MainWindow), new PropertyMetadata("0"));








        private void btnStartOrStop_Click(object sender, RoutedEventArgs e)
        {
            var con = SynchronizationContext.Current;
            System.Diagnostics.Debug.WriteLine("ButtonClick:" + con.GetHashCode().ToString());

        }


        private void TestMethod(int i, string str2)
        {
            MainWindow mw = new MainWindow(i: 1);
            //throw new Exception("あああ");
        }


        private void TestMethod(int i, string str2, string str = "default_str")
        {
            MainWindow mw = new MainWindow(i:1);
        }

    }


    public class CustomBinding : Binding
    {

        //public PropertyPath Parent { get; set; }


        public static PropertyPath GetParent(DependencyObject obj)
        {
            return (PropertyPath)obj.GetValue(ParentProperty);
        }

        public static void SetParent(DependencyObject obj, PropertyPath value)
        {
            obj.SetValue(ParentProperty, value);
        }

        // Using a DependencyProperty as the backing store for Parent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ParentProperty =
            DependencyProperty.RegisterAttached("Parent", typeof(PropertyPath), typeof(CustomBinding), new PropertyMetadata(null));










    }
}
