using Microsoft.EntityFrameworkCore;
using System.Linq;
using DevExpress.Mvvm.Native;
using System.Collections.ObjectModel;
using TorG.Models;
using TorG.Repositories;

namespace torg.services;

class DatabaseService
{

    public static ObservableCollection<Game> GetGames()
    {
        var games = new ObservableCollection<Game>();
        using (var database = new SQLiteDbContext())
        {
            database.Games.ForEach (p => games.Add(p)) ;
            database.SaveChanges();
        }
        return games;
    }
}

