using Microsoft.EntityFrameworkCore.Migrations;

namespace DungeonLessons.Data.Migrations
{
    public partial class AddTextToLessons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>("Text", "Lessons", "text", defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          
        }
    }
}
