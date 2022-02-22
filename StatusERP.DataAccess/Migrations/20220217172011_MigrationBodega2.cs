using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class MigrationBodega2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bodega_Conjuntos_ConjuntoId",
                table: "Bodega");

            migrationBuilder.DropForeignKey(
                name: "FK_Bodega_Sucursal_SucursalId",
                table: "Bodega");

            migrationBuilder.DropForeignKey(
                name: "FK_Sucursal_Conjuntos_ConjuntoId",
                table: "Sucursal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sucursal",
                table: "Sucursal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bodega",
                table: "Bodega");

            migrationBuilder.RenameTable(
                name: "Sucursal",
                newName: "Sucursales");

            migrationBuilder.RenameTable(
                name: "Bodega",
                newName: "Bodegas");

            migrationBuilder.RenameIndex(
                name: "IX_Sucursal_ConjuntoId",
                table: "Sucursales",
                newName: "IX_Sucursales_ConjuntoId");

            migrationBuilder.RenameIndex(
                name: "IX_Bodega_SucursalId",
                table: "Bodegas",
                newName: "IX_Bodegas_SucursalId");

            migrationBuilder.RenameIndex(
                name: "IX_Bodega_ConjuntoId",
                table: "Bodegas",
                newName: "IX_Bodegas_ConjuntoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sucursales",
                table: "Sucursales",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bodegas",
                table: "Bodegas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bodegas_Conjuntos_ConjuntoId",
                table: "Bodegas",
                column: "ConjuntoId",
                principalTable: "Conjuntos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bodegas_Sucursales_SucursalId",
                table: "Bodegas",
                column: "SucursalId",
                principalTable: "Sucursales",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sucursales_Conjuntos_ConjuntoId",
                table: "Sucursales",
                column: "ConjuntoId",
                principalTable: "Conjuntos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bodegas_Conjuntos_ConjuntoId",
                table: "Bodegas");

            migrationBuilder.DropForeignKey(
                name: "FK_Bodegas_Sucursales_SucursalId",
                table: "Bodegas");

            migrationBuilder.DropForeignKey(
                name: "FK_Sucursales_Conjuntos_ConjuntoId",
                table: "Sucursales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sucursales",
                table: "Sucursales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bodegas",
                table: "Bodegas");

            migrationBuilder.RenameTable(
                name: "Sucursales",
                newName: "Sucursal");

            migrationBuilder.RenameTable(
                name: "Bodegas",
                newName: "Bodega");

            migrationBuilder.RenameIndex(
                name: "IX_Sucursales_ConjuntoId",
                table: "Sucursal",
                newName: "IX_Sucursal_ConjuntoId");

            migrationBuilder.RenameIndex(
                name: "IX_Bodegas_SucursalId",
                table: "Bodega",
                newName: "IX_Bodega_SucursalId");

            migrationBuilder.RenameIndex(
                name: "IX_Bodegas_ConjuntoId",
                table: "Bodega",
                newName: "IX_Bodega_ConjuntoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sucursal",
                table: "Sucursal",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bodega",
                table: "Bodega",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bodega_Conjuntos_ConjuntoId",
                table: "Bodega",
                column: "ConjuntoId",
                principalTable: "Conjuntos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bodega_Sucursal_SucursalId",
                table: "Bodega",
                column: "SucursalId",
                principalTable: "Sucursal",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sucursal_Conjuntos_ConjuntoId",
                table: "Sucursal",
                column: "ConjuntoId",
                principalTable: "Conjuntos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
