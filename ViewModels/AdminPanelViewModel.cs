using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;
using TorG.Commands;
using TorG.Models;
using TorG.Navigations;
using TorG.Repositories;



namespace TorG.ViewModels;

internal class AdminPanelViewModel : BaseViewModel
{
    private readonly NavigationStore _navigationStore;
    public ObservableCollection<Game> Games { get; set; }

    #region PrivateValues

    private string _editpage_mainphoto = "";
    private string _editpage_photo1 = "";
    private string _editpage_photo2 = "";
    private string _editpage_photo3 = "";
    private string _editpage_photo4 = "";
    private string _gamename;
    private string _genre;
    private string _developerpublisher;
    private string _textlang;
    private string _soundlang;
    private string _windows;
    private string _processor;
    private int _ram;
    private string _videocard;
    private float _diskspace;
    private string _version;
    private string _description;
    #endregion

    #region Props

    public string EditPage_MainPhoto
    {
        get { return _editpage_mainphoto; }
        set { _editpage_mainphoto = value; OnPropertyChanged(nameof(EditPage_MainPhoto)); }
    }

    public string EditPage_Photo1
    {
        get { return _editpage_photo1; }
        set { _editpage_photo1 = value; OnPropertyChanged(nameof(EditPage_Photo1)); }
    }

    public string EditPage_Photo2
    {
        get { return _editpage_photo2; }
        set { _editpage_photo2 = value; OnPropertyChanged(nameof(EditPage_Photo2)); }
    }

    public string EditPage_Photo3
    {
        get { return _editpage_photo3; }
        set { _editpage_photo3 = value; OnPropertyChanged(nameof(EditPage_Photo3)); }
    }

    public string EditPage_Photo4
    {
        get { return _editpage_photo4; }
        set { _editpage_photo4 = value; OnPropertyChanged(nameof(EditPage_Photo4)); }
    }

    public string GameName
    {
        get { return _gamename; }
        set { _gamename = value; OnPropertyChanged(nameof(GameName)); }
    }

    public string Genre
    {
        get { return _genre; }
        set { _genre = value; OnPropertyChanged(nameof(Genre)); }
    }

    public string DeveloperPublisher
    {
        get { return _developerpublisher; }
        set { _developerpublisher = value; OnPropertyChanged(nameof(DeveloperPublisher)); }
    }

    public string TextLang
    {
        get { return _textlang; }
        set { _textlang = value; OnPropertyChanged(nameof(TextLang)); }
    }

    public string SoundLang
    {
        get { return _soundlang; }
        set { _soundlang = value; OnPropertyChanged(nameof(SoundLang)); }
    }

    public string Windows
    {
        get { return _windows; }
        set { _windows = value; OnPropertyChanged(nameof(Windows)); }
    }

    public string Processor
    {
        get { return _processor; }
        set { _processor = value; OnPropertyChanged(nameof(_processor)); }
    }

    public int Ram
    {
        get { return _ram; }
        set { _ram = value; OnPropertyChanged(nameof(Ram)); }
    }

    public string VideoCard
    {
        get { return _videocard; }
        set { _videocard = value; OnPropertyChanged(nameof(VideoCard)); }
    }

    public float DiskSpace
    {
        get { return _diskspace; }
        set { _diskspace = value; OnPropertyChanged(nameof(DiskSpace)); }
    }

    public string Version
    {
        get { return _version; }
        set { _version = value; OnPropertyChanged(nameof(Version)); }
    }

    public string Description 
    {
        get { return _description; }
        set { _description =  value; OnPropertyChanged(nameof(Description)); }
    }


    #endregion

    #region Commands

    public ICommand ChooseFileCommand { get; set; }
    public ICommand AddButtonCommand { get; set; }

    #endregion

    public AdminPanelViewModel(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;

        EditPage_MainPhoto = "../Static Files/img/upload-icon.png";
        EditPage_Photo1 = "../Static Files/img/plus-icon.png";
        EditPage_Photo2 = "../Static Files/img/plus-icon.png";
        EditPage_Photo3 = "../Static Files/img/plus-icon.png";
        EditPage_Photo4 = "../Static Files/img/plus-icon.png";
        ChooseFileCommand = new RelayCommand(ExecuteChooseImage);
        AddButtonCommand = new RelayCommand(ExecuteAddButtonCommand);
    }

    private void ExecuteAddButtonCommand(object? obj)
    {
        using (var context = new SQLiteDbContext())
        {
            context.Games.Add(new Game()
            {
                Name = GameName,
                Genre = Genre,
                Developerpublisher = DeveloperPublisher,
                Textlang = TextLang,
                SoundLang = SoundLang,
                Windows = Windows,
                Processor = Processor,
                Ram = Ram,
                VideoCard = VideoCard,
                DiskSpace = DiskSpace,
                Version = Version,
                Description = Description,
                MainPhoto = EditPage_MainPhoto,
                Photo1 = EditPage_Photo1,
                Photo2 = EditPage_Photo2,
                Photo3 = EditPage_Photo3,
                Photo4 = EditPage_Photo4,

            });

            context.SaveChanges();
        }
    }

    private void ExecuteChooseImage(object? parameter)
    {

        Button? ButtonAddPhoto = parameter as Button;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Image Files | *.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
        if (openFileDialog.ShowDialog() == true)
        {
            if (String.Equals(ButtonAddPhoto?.Name, "MainPhoto"))
                EditPage_MainPhoto = openFileDialog.FileName;
            else if (String.Equals(ButtonAddPhoto?.Name, "photo1"))
                EditPage_Photo1 = openFileDialog.FileName;
            else if (String.Equals(ButtonAddPhoto?.Name, "photo2"))
                EditPage_Photo2 = openFileDialog.FileName;
            else if (String.Equals(ButtonAddPhoto?.Name, "photo3"))
                EditPage_Photo3 = openFileDialog.FileName;
            else if (String.Equals(ButtonAddPhoto?.Name, "photo4"))
                EditPage_Photo4 = openFileDialog.FileName;

        }
    }
}
