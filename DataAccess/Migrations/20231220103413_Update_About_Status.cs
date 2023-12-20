using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogWebSiteDataAccess.Migrations
{
    public partial class Update_About_Status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Abouts",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Abouts");
        }
    }
}
