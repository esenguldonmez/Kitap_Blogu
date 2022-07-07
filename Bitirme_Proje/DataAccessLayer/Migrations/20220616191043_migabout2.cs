using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migabout2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Mail",
                table: "Abouts");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Abouts",
                newName: "Details");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Details",
                table: "Abouts",
                newName: "Phone");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
