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
using System.ComponentModel;

namespace MIC.Wpf.Controls.Animations.Indicator
{
    /// <summary>
    /// Indicator.xaml の相互作用ロジック
    /// </summary>
    public partial class Indicator : UserControl
    {
        public Indicator()
        {
            InitializeComponent();
        }

        public static readonly  DependencyProperty IndicationThemeColorProperty =   DependencyProperty.Register(
                                                                                   "IndicationThemeColor", 
                                                                                   typeof(Color), 
                                                                                   typeof(Indicator), 
                                                                                   new PropertyMetadata(Colors.Orange));

        public Color IndicationThemeColor
        {
            get { return (Color)GetValue(IndicationThemeColorProperty); }
            set { SetValue(IndicationThemeColorProperty, value); }
        }


        public static readonly DependencyProperty DisplayTextProperty = DependencyProperty.Register(
                                                                           "DisplayText",
                                                                           typeof(string),
                                                                           typeof(Indicator),
                                                                           new PropertyMetadata());

        public string DisplayText
        {
            get { return (string)GetValue(DisplayTextProperty); }
            set { SetValue(DisplayTextProperty, value); }
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }
    }

}
