using System.Windows.Controls;
using System.Windows.Interactivity;
using System.Windows.Input;
using System.Windows;
using MIC.Wpf.BindableStructs;

namespace MIC.Wpf.Common.Behaviors
{
    public class TextBoxSelectBehaviors
    {
        public static bool GetSelectAllTextOnFocus(TextBox textBox)
        {
            return (bool)textBox.GetValue(SelectAllTextOnFocusProperty);
        }

        public static void SetSelectAllTextOnFocus(TextBox textBox, bool value)
        {
            textBox.SetValue(SelectAllTextOnFocusProperty, value);
        }

        public static readonly DependencyProperty SelectAllTextOnFocusProperty =
            DependencyProperty.RegisterAttached(
                "SelectAllTextOnFocus",
                typeof(bool),
                typeof(TextBoxSelectBehaviors),
                new UIPropertyMetadata(false, OnSelectAllTextOnFocusChanged));



        private static void OnSelectAllTextOnFocusChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var textBox = d as TextBox;
            if (textBox == null) return;

            if (e.NewValue is bool == false) return;

            if ((bool)e.NewValue)
            {
                textBox.GotFocus += SelectAll;
                textBox.PreviewMouseDown += IgnoreMouseButton;
            }
            else
            {
                textBox.GotFocus -= SelectAll;
                textBox.PreviewMouseDown -= IgnoreMouseButton;
            }
        }

        private static void SelectAll(object sender, RoutedEventArgs e)
        {
            var textBox = e.OriginalSource as TextBox;
            if (textBox == null) return;
            textBox.SelectAll();
        }

        private static void IgnoreMouseButton(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null || textBox.IsKeyboardFocusWithin) return;

            e.Handled = true;
            textBox.Focus();
        }


        public static bool GetCaretToLast(DependencyObject obj)
        {
            return (bool)obj.GetValue(CaretToLastProperty);
        }

        public static void SetCaretToLast(DependencyObject obj, bool value)
        {
            obj.SetValue(CaretToLastProperty, value);
        }

        // Using a DependencyProperty as the backing store for CaretToLast.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CaretToLastProperty =
            DependencyProperty.RegisterAttached("CaretToLast", typeof(bool), typeof(TextBoxSelectBehaviors), new UIPropertyMetadata(false, OnCaretToLast));


        private static void OnCaretToLast(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var textBox = d as TextBox;
            if (textBox == null) return;

            if (e.NewValue is bool == false) return;

            if ((bool)e.NewValue)
            {
                textBox.GotFocus += SetOnCaretToLast;
            }
            else
            {
                textBox.GotFocus -= SetOnCaretToLast;
            }
        }


        private static void SetOnCaretToLast(object sender, RoutedEventArgs e)
        {
            var textBox = e.OriginalSource as TextBox;
            if (textBox == null) return;

            textBox.CaretIndex = textBox.Text.Length;

        }

    }
}



