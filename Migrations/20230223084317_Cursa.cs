using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_MPD.Migrations
{
    public partial class Cursa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CursaID",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cursa",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CursaName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursa", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Overview_CursaID",
                table: "Overview",
                column: "CursaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Overview_Cursa_CursaID",
                table: "Overview",
                column: "CursaID",
                principalTable: "Cursa",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Overview_Cursa_CursaID",
                table: "Overview");

            migrationBuilder.DropTable(
                name: "Cursa");

            migrationBuilder.DropIndex(
                name: "IX_Overview_CursaID",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "CursaID",
                table: "Overview");
        }
    }
}
