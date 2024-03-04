using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TorG.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GameName = table.Column<string>(type: "TEXT", nullable: true),
                    Genre = table.Column<string>(type: "TEXT", nullable: true),
                    Developerpublisher = table.Column<string>(type: "TEXT", nullable: true),
                    Textlang = table.Column<string>(type: "TEXT", nullable: true),
                    SoundLang = table.Column<string>(type: "TEXT", nullable: true),
                    Windows = table.Column<string>(type: "TEXT", nullable: true),
                    Processor = table.Column<string>(type: "TEXT", nullable: true),
                    Ram = table.Column<int>(type: "INTEGER", nullable: false),
                    VideoCard = table.Column<string>(type: "TEXT", nullable: true),
                    DiskSpace = table.Column<float>(type: "REAL", nullable: false),
                    Version = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    SmallDescription = table.Column<string>(type: "TEXT", nullable: true),
                    MainPhoto = table.Column<string>(type: "TEXT", nullable: true),
                    Photo1 = table.Column<string>(type: "TEXT", nullable: true),
                    Photo2 = table.Column<string>(type: "TEXT", nullable: true),
                    Photo3 = table.Column<string>(type: "TEXT", nullable: true),
                    Photo4 = table.Column<string>(type: "TEXT", nullable: true),
                    Link = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Surname = table.Column<string>(type: "TEXT", nullable: true),
                    Username = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
