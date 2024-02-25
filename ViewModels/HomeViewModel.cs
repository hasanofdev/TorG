using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TorG.Commands;
using TorG.Navigations;

namespace TorG.ViewModels;

internal class HomeViewModel : BaseViewModel
{

    private readonly NavigationStore _navigationStore;

    #region CommandsProp

    public ICommand SignInCommand { get; set; }

    #endregion

    public HomeViewModel(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;

        SignInCommand = new RelayCommand(ExecuteSignInCommand);
    }

    private void ExecuteSignInCommand(object? parameter) => _navigationStore.CurrentViewModel = new LoginViewModel(_navigationStore);
}
