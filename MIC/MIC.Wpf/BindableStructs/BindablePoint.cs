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

namespace MIC.Wpf.BindableStructs
{

    public class BindablePoint : DependencyObject
    {

        public BindablePoint(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static readonly DependencyProperty XProperty =
        DependencyProperty.Register("X", typeof(double), typeof(BindablePoint),
        new FrameworkPropertyMetadata(default(double), (sender, e) =>
        {
            BindablePoint point = sender as BindablePoint;
            point.X = (double)e.NewValue;
        }));

        public static readonly DependencyProperty YProperty =
        DependencyProperty.Register("Y", typeof(double), typeof(BindablePoint),
        new FrameworkPropertyMetadata(default(double), (sender, e) =>
        {
            BindablePoint point = sender as BindablePoint;
            point.Y = (double)e.NewValue;
        }));

        public  double X
        {
            get { return (double)GetValue(XProperty); }
            set
            {
                SetValue(XProperty, value);
            }
        }

        public  double Y
        {
            get { return (double)GetValue(YProperty); }
            set
            {
                SetValue(YProperty, value);
            }
        }
    }

}