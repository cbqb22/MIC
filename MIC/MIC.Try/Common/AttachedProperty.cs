using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MIC.Try.Common
{
    public class AttachedProperty
    {

        public static bool GetIsCenter(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsCenterProperty);
        }

        public static void SetIsCenter(DependencyObject obj, bool value)
        {
            obj.SetValue(IsCenterProperty, value);
        }

        // Using a DependencyProperty as the backing store for IsCenter.  This enables animation, styling, binding, etc...

        // 機能の多さ
        // FrameworkPropertyMetadata > PropertyMetadata 
        // 
        //public static readonly DependencyProperty IsCenterProperty =
        //    DependencyProperty.RegisterAttached("IsCenter", typeof(bool), typeof(AttachedProperty), new FrameworkPropertyMetadata(false, OnPropertyChangedCallback, OnCoerceValueCallback),OnValidateValueCallback);
        //<!--デフォルト値と違う値を設定しないと、添付プロパティはコールバックが呼ばれない-->
        public static readonly DependencyProperty IsCenterProperty =
            DependencyProperty.RegisterAttached("IsCenter", typeof(bool), typeof(AttachedProperty), new PropertyMetadata(OnPropertyChangedCallback), OnValidateValueCallback);


        // プロパティが変更になったときに呼ばれる
        public static void OnPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if(d is Label)
            {
                Label label = d as Label;
                label.MouseDoubleClick += (sender , me) => 
                {
                    MessageBox.Show(label.Content.ToString());
                };
            }


            if (d is Canvas)
            {
                Canvas canvas = d as Canvas;
                canvas.MouseRightButtonUp += (sender, me) =>
                {
                    ContextMenu cm = new ContextMenu();
                    MenuItem mi = new MenuItem();
                    mi.Header = "メニュー１";
                    MenuItem mi2 = new MenuItem();
                    mi2.Header = "メニュー２";

                    cm.Items.Add(mi);
                    cm.Items.Add(mi2);
                    cm.IsOpen = true;

                    
                };
            }

        }


        // ある値じゃなかったら、強制的に固定値を返す
        public static object OnCoerceValueCallback(DependencyObject d, object baseValue)
        {
            if ((bool)baseValue == true) return baseValue;
            return false;
        }


        // 値の検証
        public static bool OnValidateValueCallback(object value)
        {
            return true;
        }

    }
}
