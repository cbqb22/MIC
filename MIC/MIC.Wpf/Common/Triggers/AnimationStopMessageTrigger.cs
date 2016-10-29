using System.Windows;
using System.Windows.Interactivity;
using GalaSoft.MvvmLight.Messaging;
using MIC.Wpf.Common.Message;


namespace MIC.Wpf.Common.Triggers
{
    // Messenger が AnimationStopMessage を受信したときに反応するトリガー。
    public class AnimationMessageTrigger : TriggerBase<DependencyObject>
    {
        protected override void OnAttached()
        {
            base.OnAttached();

            // DialogMessage を受信したらアクションを実行
            // AssociatedObject は添付プロパティでこのトリガーを設定したオブジェクト。
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