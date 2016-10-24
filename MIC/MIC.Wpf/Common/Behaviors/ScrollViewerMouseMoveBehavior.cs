using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Interactivity;
using System.Windows.Media;
using System.Windows.Input;
using System.Windows;
using MIC.Wpf.BindableStructs;

namespace MIC.Wpf.Common.Behaviors
{
    public class ScrollViewerMouseMoveBehavior : Behavior<ScrollViewer>
    {

        public static readonly DependencyProperty MousePointProperty
                                           = DependencyProperty.Register("MousePoint",
                                           typeof(BindablePoint),
                                           typeof(ScrollViewerMouseMoveBehavior),
                                           new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
                                           );


        public ScrollViewerMouseMoveBehavior()
        {
        }

        public BindablePoint MousePoint
        {
            get { return (BindablePoint)GetValue(MousePointProperty); }
            set { SetValue(MousePointProperty, value); }
        }


        protected override void OnAttached()
        {
            base.OnAttached();
            this.AssociatedObject.MouseMove += Moved;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            this.AssociatedObject.MouseMove -= Moved;
        }


        private void Moved(object sender, MouseEventArgs e)
        {

            Point point = e.GetPosition((ScrollViewer)sender);

            //this.MousePoint = point.X.ToString();
            this.MousePoint = new BindablePoint(point.X,point.Y);

        }

    }
}
