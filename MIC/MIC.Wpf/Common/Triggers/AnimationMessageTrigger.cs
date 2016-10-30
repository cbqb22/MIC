using System.Windows;
using System.Windows.Interactivity;
using GalaSoft.MvvmLight.Messaging;
using MIC.Wpf.Common.Message;


namespace MIC.Wpf.Common.Triggers
{
    /// <summary>
    /// Messenger が AnimationActionMessage を受信したときに反応するトリガー。
    /// </summary>
    public class AnimationMessageTrigger : TriggerBase<DependencyObject>
    {
        protected override void OnAttached()
        {
            base.OnAttached();

            Messenger.Default.Register<AnimationActionMessage>(
                AssociatedObject,
                msg => InvokeActions(msg));
        }

        protected override void OnDetaching()
        {
            Messenger.Default.Unregister<AnimationActionMessage>(AssociatedObject);

            base.OnDetaching();
        }
    }
}