using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TorG.Models;

public class Game : INotifyPropertyChanged
{

    #region Fields

    private int _id;
    private string _name;
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

    private string _mainphoto;
    private string _photo1;
    private string _photo2;
    private string _photo3;
    private string _photo4;

    #endregion

    #region Props
    [Key]
    public int Id
    {
        get { return _id; }
        set { _id = value; OnPropertyChanged(nameof(Id)); }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; OnPropertyChanged(nameof(Name)); }
    }

    public string Genre
    {
        get { return _genre; }
        set { _genre = value; OnPropertyChanged(nameof(Genre)); }
    }

    public string Developerpublisher
    {
        get { return _developerpublisher; }
        set { _developerpublisher = value; OnPropertyChanged(nameof(Developerpublisher)); }
    }

    public string Textlang
    {
        get { return _textlang; }
        set { _textlang = value; OnPropertyChanged(nameof(Textlang)); }
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
        set { _processor = value; OnPropertyChanged(nameof(Processor)); }
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
        set { _description = value; OnPropertyChanged(nameof(Description)); }
    }

    public string MainPhoto
    {
        get { return _mainphoto; }
        set { _mainphoto = value; OnPropertyChanged(nameof(MainPhoto)); }
    }

    public string Photo1
    {
        get { return _photo1; }
        set { _photo1 = value; OnPropertyChanged(nameof(Photo1)); }
    }

    public string Photo2
    {
        get { return _photo2; }
        set { _photo2 = value; OnPropertyChanged(nameof(Photo2)); }
    }

    public string Photo3
    {
        get { return _photo3; }
        set { _photo3 = value; OnPropertyChanged(nameof(Photo3)); }
    }

    public string Photo4
    {
        get { return _photo4; }
        set { _photo4 = value; OnPropertyChanged(nameof(Photo4)); }
    }

    #endregion

    public Game() { }

    public Game(string name, string genre, string developerpublisher, string textlang, string soundlang, string windows, string processor, int ram, string videocard, float diskspace, string version, string description, string mainphoto, string photo1, string photo2, string photo3, string photo4)
    {
        Name = name;
        Genre = genre;
        Developerpublisher = developerpublisher;
        Textlang = textlang;
        SoundLang = soundlang;
        Windows = windows;
        Processor = processor;
        Ram = ram;
        VideoCard = videocard;
        DiskSpace = diskspace;
        Version = version;
        Description = description;
        MainPhoto = mainphoto;
        Photo1 = photo1;
        Photo2 = photo2;
        Photo3 = photo3;
        Photo4 = photo4;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChangedEventHandler handler = this.PropertyChanged;
        if (handler != null)
        {
            var e = new PropertyChangedEventArgs(propertyName);
            handler(this, e);
        }
    }
}
