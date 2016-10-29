using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIC.Wpf.Controls.Animations
{
    interface IAnimation
    {
        void Begin();
        void Stop();
        void Pause();
    }
}
