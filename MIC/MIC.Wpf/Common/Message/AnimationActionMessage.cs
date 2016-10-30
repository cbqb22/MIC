namespace MIC.Wpf.Common.Message
{
    /// <summary>
    /// AnimationActionのMessageクラス
    /// </summary>
    public class AnimationActionMessage
    {
        private AnimationActionEnum _action;
        public AnimationActionEnum Action
        {
            get
            {
                return _action;
            }

            set
            {
                _action = value;
            }
        }

        public AnimationActionMessage(AnimationActionEnum action)
        {
            Action = action;
        }
    }


    public enum AnimationActionEnum
    {
        Begin = 1,
        Stop = 2,
        Pause = 3
    }
}
