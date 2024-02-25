using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using TorG.Commands;
using TorG.Navigations;

namespace TorG.ViewModels;

internal class AdminPanelViewModel : BaseViewModel
{
    private readonly NavigationStore _navigationStore;

    #region PrivateValues

    private string _editpage_imagesource = "";
    #endregion

    #region Props

    public string EditPage_ImageSource 
    {
        get { return _editpage_imagesource;}
        set { _editpage_imagesource = value;OnPropertyChanged(nameof(EditPage_ImageSource));}
    }

    #endregion

    #region Commands

    public ICommand ChooseFileCommand { get; set; }

    #endregion

    public AdminPanelViewModel(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;

        EditPage_ImageSource = "../Static Files/img/upload-icon.png";
        ChooseFileCommand = new RelayCommand(ExecuteChooseImage);
    }

    private void ExecuteChooseImage(object? parameter)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        if(openFileDialog.ShowDialog() == true)
        {
            EditPage_ImageSource = openFileDialog.FileName;
        }
    }
}
