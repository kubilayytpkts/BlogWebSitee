using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogWebSiteDataAccess.Migrations
{
    public partial class Quotes_add_status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Quotes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Quotes");
        }
    }
}
