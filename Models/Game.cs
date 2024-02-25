using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TorG.Models;

public class Game : INotifyPropertyChanged
{
    private int _id;
    [Key]
    public int Id
    {
        get { return _id; }
        set { _id = value; OnPropertyChanged(nameof(Id)); }
    }

    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; OnPropertyChanged(nameof(Name)); }
    }

    private string _description;
    public string Description
    {
        get { return _description; }
        set { _description = value; OnPropertyChanged(nameof(Description)); }
    }

    private string _genre;
    public string Genre
    {
        get { return _genre; }
        set { _genre = value; OnPropertyChanged(nameof(Genre)); }
    }

    private string _developer_publisher;
    public string DeveloperPublisher
    {
        get { return _developer_publisher; }
        set { _developer_publisher = value; OnPropertyChanged(nameof(DeveloperPublisher)); }
    }

    private string _text_lang;
    public string TextLang
    {
        get { return _text_lang; }
        set { _text_lang = value; OnPropertyChanged(nameof(TextLang)); }
    }

    private string _sound_lang;
    public string SoundLang
    {
        get { return _sound_lang; }
        set { _sound_lang = value; OnPropertyChanged(nameof(SoundLang)); }
    }

    private string _windows;
    public string Windows
    {
        get { return _windows; }
        set { _windows = value; OnPropertyChanged(nameof(Windows)); }
    }

    private string _processor;
    public string Processor
    {
        get { return _processor; }
        set { _windows = value; OnPropertyChanged(nameof(Processor)); }
    }

    private int _ram;
    public int RAM
    {
        get { return _ram; }
        set { _ram = value; OnPropertyChanged(nameof(RAM)); }
    }

    private string _video_card;
    public string VideoCard
    {
        get { return _video_card; }
        set { _video_card = value; OnPropertyChanged(nameof(VideoCard)); }
    }

    private float _disk_space;
    public float DiskSpace
    {
        get { return _disk_space; }
        set { _disk_space = value; OnPropertyChanged(nameof(DiskSpace)); }
    }

    private string _version;
    public string Version
    {
        get { return _version; }
        set { _version = value; OnPropertyChanged(nameof(Version)); }
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
