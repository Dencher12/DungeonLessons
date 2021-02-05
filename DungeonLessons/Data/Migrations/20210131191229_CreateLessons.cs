using Microsoft.EntityFrameworkCore.Migrations;

namespace DungeonLessons.Data.Migrations
{
    public partial class CreateLessons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_Lessons", x => x.Id); });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
