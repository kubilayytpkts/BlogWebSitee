using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogWebSiteDataAccess.Migrations
{
    public partial class updatedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BannerShortaAbout",
                table: "Banners",
                newName: "BannerShortAbout1");

            migrationBuilder.AddColumn<string>(
                name: "BannerShortAbout",
                table: "Banners",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BannerShortAbout",
                table: "Banners");

            migrationBuilder.RenameColumn(
                name: "BannerShortAbout1",
                table: "Banners",
                newName: "BannerShortaAbout");
        }
    }
}
