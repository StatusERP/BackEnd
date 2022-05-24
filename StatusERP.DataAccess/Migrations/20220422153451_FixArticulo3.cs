using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixArticulo3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_UnidadesMedida_UnidadAlmacenFKId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_UnidadesMedida_UnidadEmpaqueFKId",
              
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_UnidadAlmacenFKId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "UnidadAlmacen",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "UnidadAlmacenFKId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.RenameColumn(
                name: "UnidadVenta",
                schema: "H2C",
                table: "Articulos",
                newName: "UnidadVentaId");

            migrationBuilder.RenameColumn(
                name: "UnidadEmpaqueFKId",
                schema: "H2C",
                table: "Articulos",
                newName: "UnidadEmpaqueId");

            migrationBuilder.RenameColumn(
                name: "UnidadEmpaque",
                schema: "H2C",
                table: "Articulos",
                newName: "UnidadAlmacenId");

            migrationBuilder.RenameIndex(
                name: "IX_Articulos_UnidadEmpaqueFKId",
                schema: "H2C",
                table: "Articulos",
                newName: "IX_Articulos_UnidadEmpaqueId");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_UnidadAlmacenId",
                schema: "H2C",
                table: "Articulos",
                column: "UnidadAlmacenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_UnidadesMedida_UnidadAlmacenId",
                schema: "H2C",
                table: "Articulos",
                column: "UnidadAlmacenId",
                principalSchema: "H2C",
                principalTable: "UnidadesMedida",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_UnidadesMedida_UnidadEmpaqueId",
                schema: "H2C",
                table: "Articulos",
                column: "UnidadEmpaqueId",
                principalSchema: "H2C",
                principalTable: "UnidadesMedida",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_UnidadesMedida_UnidadAlmacenId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_UnidadesMedida_UnidadEmpaqueId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_UnidadAlmacenId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.RenameColumn(
                name: "UnidadVentaId",
                schema: "H2C",
                table: "Articulos",
                newName: "UnidadVenta");

            migrationBuilder.RenameColumn(
                name: "UnidadEmpaqueId",
                schema: "H2C",
                table: "Articulos",
                newName: "UnidadEmpaqueFKId");

            migrationBuilder.RenameColumn(
                name: "UnidadAlmacenId",
                schema: "H2C",
                table: "Articulos",
                newName: "UnidadEmpaque");

            migrationBuilder.RenameIndex(
                name: "IX_Articulos_UnidadEmpaqueId",
                schema: "H2C",
                table: "Articulos",
                newName: "IX_Articulos_UnidadEmpaqueFKId");

            migrationBuilder.AddColumn<int>(
                name: "UnidadAlmacen",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnidadAlmacenFKId",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_UnidadAlmacenFKId",
                schema: "H2C",
                table: "Articulos",
                column: "UnidadAlmacenFKId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_UnidadesMedida_UnidadAlmacenFKId",
                schema: "H2C",
                table: "Articulos",
                column: "UnidadAlmacenFKId",
                principalSchema: "H2C",
                principalTable: "UnidadesMedida",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_UnidadesMedida_UnidadEmpaqueFKId",
                schema: "H2C",
                table: "Articulos",
                column: "UnidadEmpaqueFKId",
                principalSchema: "H2C",
                principalTable: "UnidadesMedida",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
