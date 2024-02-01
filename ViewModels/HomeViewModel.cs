using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorG.Navigations;

namespace TorG.ViewModels;

internal class HomeViewModel : BaseViewModel
{

    private readonly NavigationStore _navigationStore;

    public HomeViewModel(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
    }
}
