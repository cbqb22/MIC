using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using MIC.Wpf.Common.Message;
using MIC.Wpf.Controls.Animations.Indicator;
using Microsoft.Practices.ServiceLocation;



namespace ControlLibrary.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel() : base(Messenger.Default)
        {
            AnimationActionCommand = new RelayCommand(AnimationActionCommandExecute);            

        }


        private ICommand _animationActionCommand;
        public ICommand AnimationActionCommand
        {
            get
            {
                return _animationActionCommand;
            }

            set
            {
                _animationActionCommand = value;
            }
        }



        private void AnimationActionCommandExecute()
        {
            MessengerInstance.Send(new AnimationActionMessage(AnimationActionEnum.Begin));
        }


    }
}