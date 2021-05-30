using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekt_Biblioteka.Migrations
{
    public partial class AddLibraryNumberToBookModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LibraryNumber",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LibraryNumber",
                table: "Book");
        }
    }
}
