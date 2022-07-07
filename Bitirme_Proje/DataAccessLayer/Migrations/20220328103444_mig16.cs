using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Portfolios");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Portfolios",
                newName: "Sayfa");

            migrationBuilder.RenameColumn(
                name: "Platform",
                table: "Portfolios",
                newName: "Okuduklarim");

            migrationBuilder.AddColumn<string>(
                name: "Konu",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Konu",
                table: "Portfolios");

            migrationBuilder.RenameColumn(
                name: "Sayfa",
                table: "Portfolios",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Okuduklarim",
                table: "Portfolios",
                newName: "Platform");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Portfolios",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
