using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogWebSiteDataAccess.Migrations
{
    public partial class update_Com_SocialMedia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YoutubeLink",
                table: "SocialMedias",
                newName: "LinkedinLink");

            migrationBuilder.RenameColumn(
                name: "SocialMediID",
                table: "SocialMedias",
                newName: "SocialMediaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LinkedinLink",
                table: "SocialMedias",
                newName: "YoutubeLink");

            migrationBuilder.RenameColumn(
                name: "SocialMediaID",
                table: "SocialMedias",
                newName: "SocialMediID");
        }
    }
}
