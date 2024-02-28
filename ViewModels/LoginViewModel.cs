using System.Windows.Input;
using TorG.Commands;
using TorG.Navigations;
using System.Security;
using TorG.Extension_Methods;

namespace TorG.ViewModels;

class LoginViewModel : BaseViewModel
{
    private string _username;

    public string Username
    {
        get { return _username; }
        set { _username = value; OnPropertyChanged(nameof(Username)); }
    }

    private readonly NavigationStore _navigationStore;

    #region CommandsProp
    public ICommand BackHomeCommand { get; set; }
    public ICommand LoginCommand { get; set; }

    #endregion

    public LoginViewModel(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;

        BackHomeCommand = new RelayCommand(ExecuteBackHomeCommand);
        LoginCommand = new RelayCommand(ExecuteLoginCommand);
    }

    private void ExecuteBackHomeCommand(object? obj)
    {
        _navigationStore.CurrentViewModel = new HomeViewModel(_navigationStore);
    }

    private SecureString _password;

    public SecureString Password
    {
        get
        {
            return _password;
        }
        set
        {
            _password = value;
            OnPropertyChanged(nameof(Password));
        }
    }


    //private string _errortext;

    //public string ErrorText
    //{
    //    get { return _errortext; }
    //    set { _errortext = value; OnPropertyChanged(nameof(ErrorText)); }
    //}

    private void ExecuteLoginCommand(object? obj)
    {
        if (Username == "elshad" || Password.ToStringForSecureStr() == "2005")
                _navigationStore.CurrentViewModel = new AdminPanelViewModel(_navigationStore);

    }
}
