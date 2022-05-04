using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixLote1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Proveedor",
                schema: "H2C",
                table: "Lotes");

            migrationBuilder.AddColumn<int>(
                name: "ProveedorId",
                schema: "H2C",
                table: "Lotes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lotes_ProveedorId",
                schema: "H2C",
                table: "Lotes",
                column: "ProveedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lotes_Proveedores_ProveedorId",
                schema: "H2C",
                table: "Lotes",
                column: "ProveedorId",
                principalSchema: "H2C",
                principalTable: "Proveedores",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lotes_Proveedores_ProveedorId",
                schema: "H2C",
                table: "Lotes");

            migrationBuilder.DropIndex(
                name: "IX_Lotes_ProveedorId",
                schema: "H2C",
                table: "Lotes");

            migrationBuilder.DropColumn(
                name: "ProveedorId",
                schema: "H2C",
                table: "Lotes");

            migrationBuilder.AddColumn<string>(
                name: "Proveedor",
                schema: "H2C",
                table: "Lotes",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }
    }
}
