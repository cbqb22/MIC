using System.Windows;
using System.Windows.Interactivity;
using GalaSoft.MvvmLight.Messaging;
using MIC.Wpf.Common.Message;
using System.Windows.Controls;
using MIC.Wpf.Controls.Animations.Indicator;
using MIC.Wpf.Controls.Animations;

namespace MIC.Wpf.Common.Actions
{
    // Animationのアクション
    public class AnimationAction : TriggerAction<DependencyObject>
    {
        protected override void Invoke(object parameter)
        {
            var msg = parameter as AnimationActionMessage;
            if (msg != null)
            {
                var indicator = AssociatedObject  as IAnimation;

                if (indicator != null)
                {
                    switch (msg.Action)
                    {
                        case AnimationActionEnum.Begin:
                            indicator.Begin();
                            break;
                        case AnimationActionEnum.Stop:
                            indicator.Stop();
                            break;
                        case AnimationActionEnum.Pause:
                            indicator.Pause();
                            break;

                        default:
                            break;


                    }
                }
            }
        }
    }
}
