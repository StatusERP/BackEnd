using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixNivelPrecio_Indice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IxCodNivelPrecio",
                schema: "H2C",
                table: "NivelesPrecios",
                column: "CodNivelPrecio",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IxCodNivelPrecio",
                schema: "H2C",
                table: "NivelesPrecios");
        }
    }
}
