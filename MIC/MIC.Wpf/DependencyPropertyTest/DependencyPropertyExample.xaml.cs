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
using MIC.Wpf.BindableStructs;

namespace MIC.Wpf.DependencyPropertyTest
{
    /// <summary>
    /// DependencyPropertyExample.xaml の相互作用ロジック
    /// </summary>
    public partial class DependencyPropertyExample : UserControl
    {
        public DependencyPropertyExample()
        {
            InitializeComponent();

        }

        public static readonly DependencyProperty MyNameProperty
                                   = DependencyProperty.Register("MyName",
                                   typeof(string),
                                   typeof(DependencyPropertyExample),
                                   new PropertyMetadata());


        public string MyName
        {
            get { return (string)GetValue(MyNameProperty); }
            set { SetValue(MyNameProperty, value); }
        }

        private BindablePoint _point;
        public BindablePoint Point
        {
            get
            {
                return _point;
            }

            set
            {
                _point = value;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format("X:{0} Y:{1}", Point.X, Point.Y));
            MessageBox.Show(string.Format("ViewからViewModelへ{0}", string.IsNullOrEmpty(MyName) ? "Null" : MyName));

            MyName = "ViewModelからViewへ";

        }


    }

}
