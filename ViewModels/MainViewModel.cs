﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorG.Navigations;

namespace TorG.ViewModels;

internal class MainViewModel : BaseViewModel
{
    private readonly NavigationStore _navigationStore;
    public BaseViewModel CurrentViewModel => _navigationStore.CurrentViewModel;

    public MainViewModel(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
        navigationStore.CurrentViewModelChanged += NavigationStore_CurrentViewModelChanged;
    }

    private void NavigationStore_CurrentViewModelChanged()=>OnPropertyChanged(nameof(CurrentViewModel));
}
