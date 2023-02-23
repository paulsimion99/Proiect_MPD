using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_MPD.Migrations
{
    public partial class Locatie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocatieID",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Locatie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocatieName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locatie", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Overview_LocatieID",
                table: "Overview",
                column: "LocatieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Overview_Locatie_LocatieID",
                table: "Overview",
                column: "LocatieID",
                principalTable: "Locatie",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Overview_Locatie_LocatieID",
                table: "Overview");

            migrationBuilder.DropTable(
                name: "Locatie");

            migrationBuilder.DropIndex(
                name: "IX_Overview_LocatieID",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "LocatieID",
                table: "Overview");
        }
    }
}
