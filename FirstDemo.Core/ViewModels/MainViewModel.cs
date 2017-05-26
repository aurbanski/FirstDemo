using MvvmCross.Core.ViewModels;

namespace FirstDemo.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                RaisePropertyChanged(() => FullName);
            }
        }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                RaisePropertyChanged(() => FullName);
            }
        }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", _firstName, _lastName);
            }
        }

        public MainViewModel()
        {
        }
        
        //TODO: For more information see: https://www.mvvmcross.com/documentation/fundamentals/navigation
        public void Init()
        {
        }
        
        public override void Start()
        {
            //TODO: Add starting logic here
        }
    }
}