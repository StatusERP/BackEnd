using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixArticulo4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_ClasificacionesInv_ClasifInv1Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_ClasificacionesInv_ClasifInv2Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_UnidadesMedida_UnidadVentaFKId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_ClasifInv1Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_ClasifInv2Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_UnidadVentaFKId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "ClasifInv1Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "ClasifInv2Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "UnidadVentaFKId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.RenameColumn(
                name: "Clasificacion2",
                schema: "H2C",
                table: "Articulos",
                newName: "Clasificacion2Id");

            migrationBuilder.RenameColumn(
                name: "Clasificacion1",
                schema: "H2C",
                table: "Articulos",
                newName: "Clasificacion1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_Clasificacion1Id",
                schema: "H2C",
                table: "Articulos",
                column: "Clasificacion1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_Clasificacion2Id",
                schema: "H2C",
                table: "Articulos",
                column: "Clasificacion2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_UnidadVentaId",
                schema: "H2C",
                table: "Articulos",
                column: "UnidadVentaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_ClasificacionesInv_Clasificacion1Id",
                schema: "H2C",
                table: "Articulos",
                column: "Clasificacion1Id",
                principalSchema: "H2C",
                principalTable: "ClasificacionesInv",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_ClasificacionesInv_Clasificacion2Id",
                schema: "H2C",
                table: "Articulos",
                column: "Clasificacion2Id",
                principalSchema: "H2C",
                principalTable: "ClasificacionesInv",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_UnidadesMedida_UnidadVentaId",
                schema: "H2C",
                table: "Articulos",
                column: "UnidadVentaId",
                principalSchema: "H2C",
                principalTable: "UnidadesMedida",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_ClasificacionesInv_Clasificacion1Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_ClasificacionesInv_Clasificacion2Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_UnidadesMedida_UnidadVentaId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_Clasificacion1Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_Clasificacion2Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_UnidadVentaId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.RenameColumn(
                name: "Clasificacion2Id",
                schema: "H2C",
                table: "Articulos",
                newName: "Clasificacion2");

            migrationBuilder.RenameColumn(
                name: "Clasificacion1Id",
                schema: "H2C",
                table: "Articulos",
                newName: "Clasificacion1");

            migrationBuilder.AddColumn<int>(
                name: "ClasifInv1Id",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClasifInv2Id",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnidadVentaFKId",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_ClasifInv1Id",
                schema: "H2C",
                table: "Articulos",
                column: "ClasifInv1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_ClasifInv2Id",
                schema: "H2C",
                table: "Articulos",
                column: "ClasifInv2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_UnidadVentaFKId",
                schema: "H2C",
                table: "Articulos",
                column: "UnidadVentaFKId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_ClasificacionesInv_ClasifInv1Id",
                schema: "H2C",
                table: "Articulos",
                column: "ClasifInv1Id",
                principalSchema: "H2C",
                principalTable: "ClasificacionesInv",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_ClasificacionesInv_ClasifInv2Id",
                schema: "H2C",
                table: "Articulos",
                column: "ClasifInv2Id",
                principalSchema: "H2C",
                principalTable: "ClasificacionesInv",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_UnidadesMedida_UnidadVentaFKId",
                schema: "H2C",
                table: "Articulos",
                column: "UnidadVentaFKId",
                principalSchema: "H2C",
                principalTable: "UnidadesMedida",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
