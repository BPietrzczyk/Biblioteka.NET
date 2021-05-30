using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekt_Biblioteka.Migrations
{
    public partial class AddIsBorrowedToBookModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IsBorrowed",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBorrowed",
                table: "Book");
        }
    }
}
