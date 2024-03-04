﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TorG.Repositories;

#nullable disable

namespace TorG.Migrations
{
    [DbContext(typeof(SQLiteDbContext))]
    partial class SQLiteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("TorG.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Developerpublisher")
                        .HasColumnType("TEXT");

                    b.Property<float>("DiskSpace")
                        .HasColumnType("REAL");

                    b.Property<string>("GameName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Link")
                        .HasColumnType("TEXT");

                    b.Property<string>("MainPhoto")
                        .HasColumnType("TEXT");

                    b.Property<string>("Photo1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Photo2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Photo3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Photo4")
                        .HasColumnType("TEXT");

                    b.Property<string>("Processor")
                        .HasColumnType("TEXT");

                    b.Property<int>("Ram")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SmallDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("SoundLang")
                        .HasColumnType("TEXT");

                    b.Property<string>("Textlang")
                        .HasColumnType("TEXT");

                    b.Property<string>("Version")
                        .HasColumnType("TEXT");

                    b.Property<string>("VideoCard")
                        .HasColumnType("TEXT");

                    b.Property<string>("Windows")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("TorG.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
