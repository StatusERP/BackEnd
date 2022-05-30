using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class IndiceCodArticulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IxCodArticulo",
                schema: "H2C",
                table: "Articulos",
                column: "CodArticulo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IxCodArticulo",
                schema: "H2C",
                table: "Articulos");
        }
    }
}
