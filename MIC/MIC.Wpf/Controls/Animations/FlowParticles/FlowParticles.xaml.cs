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

namespace MIC.Wpf.Controls.Animations.FlowParticles
{
    /// <summary>
    /// FlowParticles.xaml の相互作用ロジック
    /// </summary>
    public partial class FlowParticles : UserControl
    {
        public FlowParticles()
        {
            InitializeComponent();

            
        }

        private List<Path> _pathList;

        public List<Path> PathList
        {
            get
            {
                return _pathList;
            }

            set
            {
                _pathList = value;
            }
        }

        private void Init()
        {
            Action a = () => 
            { Path p = new Path();
                p.Height = 2;
                p.Width = 2;
            };
        }

    }
}
