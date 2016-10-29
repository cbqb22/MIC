using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIC.Wpf.Common.Message
{
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
