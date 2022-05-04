using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class MigFixArticulosCRV : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Bodegas_Sucursales_SucursalId",
            //    schema: "H2C",
            //    table: "Bodegas");

            //migrationBuilder.DropIndex(
            //    name: "IX_Bodegas_SucursalId",
            //    schema: "H2C",
            //    table: "Bodegas");

            //migrationBuilder.DropColumn(
            //    name: "SucursalId",
            //    schema: "H2C",
            //    table: "Bodegas");

            migrationBuilder.DropColumn(
                name: "Proveedor",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.RenameColumn(
                name: "CategoriaArticulo",
                schema: "H2C",
                table: "Articulos",
                newName: "CategoriaArticuloId");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaArticuloId1",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProveedorId",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "urlimagen",
                schema: "H2C",
                table: "Articulos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_CategoriaArticuloId1",
                schema: "H2C",
                table: "Articulos",
                column: "CategoriaArticuloId1");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_ProveedorId",
                schema: "H2C",
                table: "Articulos",
                column: "ProveedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_CategoriasArticulos_CategoriaArticuloId1",
                schema: "H2C",
                table: "Articulos",
                column: "CategoriaArticuloId1",
                principalSchema: "H2C",
                principalTable: "CategoriasArticulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_Proveedores_ProveedorId",
                schema: "H2C",
                table: "Articulos",
                column: "ProveedorId",
                principalSchema: "H2C",
                principalTable: "Proveedores",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_CategoriasArticulos_CategoriaArticuloId1",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_Proveedores_ProveedorId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_CategoriaArticuloId1",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_ProveedorId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "CategoriaArticuloId1",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "ProveedorId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "urlimagen",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.RenameColumn(
                name: "CategoriaArticuloId",
                schema: "H2C",
                table: "Articulos",
                newName: "CategoriaArticulo");

            migrationBuilder.AddColumn<int>(
                name: "SucursalId",
                schema: "H2C",
                table: "Bodegas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Proveedor",
                schema: "H2C",
                table: "Articulos",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bodegas_SucursalId",
                schema: "H2C",
                table: "Bodegas",
                column: "SucursalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bodegas_Sucursales_SucursalId",
                schema: "H2C",
                table: "Bodegas",
                column: "SucursalId",
                principalSchema: "H2C",
                principalTable: "Sucursales",
                principalColumn: "Id");
        }
    }
}
