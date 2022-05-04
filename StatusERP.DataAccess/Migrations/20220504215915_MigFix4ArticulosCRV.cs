using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class MigFix4ArticulosCRV : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_Proveedores_ProveedorId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_ProveedorId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "ProveedorId",
                schema: "H2C",
                table: "Articulos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProveedorId",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_ProveedorId",
                schema: "H2C",
                table: "Articulos",
                column: "ProveedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_Proveedores_ProveedorId",
                schema: "H2C",
                table: "Articulos",
                column: "ProveedorId",
                principalSchema: "H2C",
                principalTable: "Proveedores",
                principalColumn: "Id");
        }
    }
}
