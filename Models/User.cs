using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TorG.Models;

class User : INotifyPropertyChanged

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

    private string _surname;
    public string Surname
    {
        get { return _surname; }
        set { _surname = value; OnPropertyChanged(nameof(Surname)); }
    }


    private string _username;
    public string Username
    {
        get { return _username; }
        set { _username = value; OnPropertyChanged(nameof(Username));}
    }

    private string _password;
    public string Password
    {
        get { return _password; }
        set { _password = value; OnPropertyChanged(nameof(Password)); }
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
