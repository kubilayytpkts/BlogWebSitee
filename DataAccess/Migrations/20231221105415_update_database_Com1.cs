using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogWebSiteDataAccess.Migrations
{
    public partial class update_database_Com1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Communication",
                columns: table => new
                {
                    ComID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communication", x => x.ComID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Communication");
        }
    }
}
