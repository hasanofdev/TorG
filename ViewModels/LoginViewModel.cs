using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TorG.Commands;
using TorG.Navigations;

namespace TorG.ViewModels;

class LoginViewModel : BaseViewModel
{

    private readonly NavigationStore _navigationStore;

    #region CommandsProp
    public ICommand BackHomeCommand { get; set; }

    #endregion

    public LoginViewModel(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;

        BackHomeCommand = new RelayCommand(ExecuteBackHomeCommand);
    }

    private void ExecuteBackHomeCommand(object? obj)
    {
        _navigationStore.CurrentViewModel = new HomeViewModel(_navigationStore);
    }

    //private SecureString _password;

    //public SecureString Password
    //{
    //    get
    //    {
    //        return _password;
    //    }
    //    set
    //    {
    //        _password = value;
    //        ErrorText = "";
    //        OnPropertyChanged(nameof(Password));
    //    }
    //}


    //private string _errortext;

    //public string ErrorText
    //{
    //    get { return _errortext; }
    //    set { _errortext = value; OnPropertyChanged(nameof(ErrorText)); }
    //}
}
