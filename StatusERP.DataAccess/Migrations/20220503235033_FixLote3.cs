using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixLote3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Lotes_ArticuloId",
                schema: "H2C",
                table: "Lotes",
                column: "ArticuloId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lotes_Articulos_ArticuloId",
                schema: "H2C",
                table: "Lotes",
                column: "ArticuloId",
                principalSchema: "H2C",
                principalTable: "Articulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lotes_Articulos_ArticuloId",
                schema: "H2C",
                table: "Lotes");

            migrationBuilder.DropIndex(
                name: "IX_Lotes_ArticuloId",
                schema: "H2C",
                table: "Lotes");
        }
    }
}
