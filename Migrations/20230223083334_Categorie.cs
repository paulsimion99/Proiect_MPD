using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_MPD.Migrations
{
    public partial class Categorie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategorieID",
                table: "Overview",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategorieName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Overview_CategorieID",
                table: "Overview",
                column: "CategorieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Overview_Categorie_CategorieID",
                table: "Overview",
                column: "CategorieID",
                principalTable: "Categorie",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Overview_Categorie_CategorieID",
                table: "Overview");

            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.DropIndex(
                name: "IX_Overview_CategorieID",
                table: "Overview");

            migrationBuilder.DropColumn(
                name: "CategorieID",
                table: "Overview");
        }
    }
}
