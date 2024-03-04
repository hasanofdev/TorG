using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using torg.services;
using TorG.Commands;
using TorG.Models;
using TorG.Navigations;

namespace TorG.ViewModels;

internal class HomeViewModel : BaseViewModel
{

    private readonly NavigationStore _navigationStore;
    public ObservableCollection<Game> Games { get; private set; }

    #region CommandsProp

    public ICommand SignInCommand { get; set; }

    #endregion

    public HomeViewModel(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;

        SignInCommand = new RelayCommand(ExecuteSignInCommand);
        Games = DatabaseService.GetGames();
    }

    private void ExecuteSignInCommand(object? parameter) => _navigationStore.CurrentViewModel = new LoginViewModel(_navigationStore);
}
