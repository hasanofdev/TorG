//using Microsoft.EntityFrameworkCore;
//using System.Collections.ObjectModel;
//using TorG.Models;
//using TorG.Repositories;
//using System.Linq;
//using DevExpress.Mvvm.Native;

//namespace TorG.Services;

//class Database_Service
//{

//    public static ObservableCollection<Game> GetProducts()
//    {
//        var Games = new ObservableCollection<Game>();
//        using (var database = new SQLiteDbContext())
//        {
//            database.Games.ForEach(p => Games.Add(p));
//            database.SaveChanges();
//        }
//        return Games;
//    }

//    public static void SaveProducts(Game Games)
//    {
//        using (SQLiteDbContext database = new SQLiteDbContext())
//        {
//            database.Games.Add(Games);
//            database.SaveChanges();
//        }
//    }
//}

