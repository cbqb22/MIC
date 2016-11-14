using System;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using MIC.Wpf.Common.Message;
using System.Collections.ObjectModel;



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

            this.Users = new ObservableCollection<User>();
            User u = new User();
            u.Name = "éOè„";
            u.Nickname = "Ç’Ç¡Çø";
            u.Birthday = DateTime.Now;
            u.Age = 34;
            u.Birthplace = "ìåãû";
            //this.Users.Add(u);
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

        public ObservableCollection<User> Users
        {
            get
            {
                return _users;
            }

            set
            {
                _users = value;
            }
        }

        private bool IsStop = false;

        private void AnimationActionCommandExecute()
        {
            if (IsStop)
            {
                MessengerInstance.Send(new AnimationActionMessage(AnimationActionEnum.Begin));
                IsStop = false;
            }
            else
            {
                MessengerInstance.Send(new AnimationActionMessage(AnimationActionEnum.Stop));
                IsStop = true;
            }

        }

        private ObservableCollection<User> _users;


    }

    public class User
    {
        private string _nickname;

        private string _name;

        private string _birthplace;

        private int _age;

        private DateTime _birthday;

        public string Nickname
        {
            get
            {
                return _nickname;
            }

            set
            {
                _nickname = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Birthplace
        {
            get
            {
                return _birthplace;
            }

            set
            {
                _birthplace = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return _birthday;
            }

            set
            {
                _birthday = value;
            }
        }
    }

}