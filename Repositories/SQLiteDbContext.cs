using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorG.Models;

namespace TorG.Repositories;

internal class SQLiteDbContext : DbContext
{
    public DbSet<Game> Games { get; set; }
    public DbSet<User> Users { get; set; }

    private string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite($"Data Source = ../../../TorG.db");

}
