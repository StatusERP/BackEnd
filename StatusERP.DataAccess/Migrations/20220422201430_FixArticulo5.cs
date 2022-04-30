using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixArticulo5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_ClasificacionesInv_ClasifInv3Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_ClasificacionesInv_ClasifInv4Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_ClasificacionesInv_ClasifInv5Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_ClasificacionesInv_ClasifInv6Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_ClasifInv3Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_ClasifInv4Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_ClasifInv5Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_ClasifInv6Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "ClasifInv3Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "ClasifInv4Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "ClasifInv5Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "ClasifInv6Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.RenameColumn(
                name: "Clasificacion6",
                schema: "H2C",
                table: "Articulos",
                newName: "Clasificacion6Id");

            migrationBuilder.RenameColumn(
                name: "Clasificacion5",
                schema: "H2C",
                table: "Articulos",
                newName: "Clasificacion5Id");

            migrationBuilder.RenameColumn(
                name: "Clasificacion4",
                schema: "H2C",
                table: "Articulos",
                newName: "Clasificacion4Id");

            migrationBuilder.RenameColumn(
                name: "Clasificacion3",
                schema: "H2C",
                table: "Articulos",
                newName: "Clasificacion3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_Clasificacion3Id",
                schema: "H2C",
                table: "Articulos",
                column: "Clasificacion3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_Clasificacion4Id",
                schema: "H2C",
                table: "Articulos",
                column: "Clasificacion4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_Clasificacion5Id",
                schema: "H2C",
                table: "Articulos",
                column: "Clasificacion5Id");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_Clasificacion6Id",
                schema: "H2C",
                table: "Articulos",
                column: "Clasificacion6Id");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_CodArticulo",
                schema: "H2C",
                table: "Articulos",
                column: "CodArticulo",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_ClasificacionesInv_Clasificacion3Id",
                schema: "H2C",
                table: "Articulos",
                column: "Clasificacion3Id",
                principalSchema: "H2C",
                principalTable: "ClasificacionesInv",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_ClasificacionesInv_Clasificacion4Id",
                schema: "H2C",
                table: "Articulos",
                column: "Clasificacion4Id",
                principalSchema: "H2C",
                principalTable: "ClasificacionesInv",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_ClasificacionesInv_Clasificacion5Id",
                schema: "H2C",
                table: "Articulos",
                column: "Clasificacion5Id",
                principalSchema: "H2C",
                principalTable: "ClasificacionesInv",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_ClasificacionesInv_Clasificacion6Id",
                schema: "H2C",
                table: "Articulos",
                column: "Clasificacion6Id",
                principalSchema: "H2C",
                principalTable: "ClasificacionesInv",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_ClasificacionesInv_Clasificacion3Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_ClasificacionesInv_Clasificacion4Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_ClasificacionesInv_Clasificacion5Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_ClasificacionesInv_Clasificacion6Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_Clasificacion3Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_Clasificacion4Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_Clasificacion5Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_Clasificacion6Id",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_CodArticulo",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.RenameColumn(
                name: "Clasificacion6Id",
                schema: "H2C",
                table: "Articulos",
                newName: "Clasificacion6");

            migrationBuilder.RenameColumn(
                name: "Clasificacion5Id",
                schema: "H2C",
                table: "Articulos",
                newName: "Clasificacion5");

            migrationBuilder.RenameColumn(
                name: "Clasificacion4Id",
                schema: "H2C",
                table: "Articulos",
                newName: "Clasificacion4");

            migrationBuilder.RenameColumn(
                name: "Clasificacion3Id",
                schema: "H2C",
                table: "Articulos",
                newName: "Clasificacion3");

            migrationBuilder.AddColumn<int>(
                name: "ClasifInv3Id",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClasifInv4Id",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClasifInv5Id",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClasifInv6Id",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_ClasifInv3Id",
                schema: "H2C",
                table: "Articulos",
                column: "ClasifInv3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_ClasifInv4Id",
                schema: "H2C",
                table: "Articulos",
                column: "ClasifInv4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_ClasifInv5Id",
                schema: "H2C",
                table: "Articulos",
                column: "ClasifInv5Id");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_ClasifInv6Id",
                schema: "H2C",
                table: "Articulos",
                column: "ClasifInv6Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_ClasificacionesInv_ClasifInv3Id",
                schema: "H2C",
                table: "Articulos",
                column: "ClasifInv3Id",
                principalSchema: "H2C",
                principalTable: "ClasificacionesInv",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_ClasificacionesInv_ClasifInv4Id",
                schema: "H2C",
                table: "Articulos",
                column: "ClasifInv4Id",
                principalSchema: "H2C",
                principalTable: "ClasificacionesInv",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_ClasificacionesInv_ClasifInv5Id",
                schema: "H2C",
                table: "Articulos",
                column: "ClasifInv5Id",
                principalSchema: "H2C",
                principalTable: "ClasificacionesInv",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_ClasificacionesInv_ClasifInv6Id",
                schema: "H2C",
                table: "Articulos",
                column: "ClasifInv6Id",
                principalSchema: "H2C",
                principalTable: "ClasificacionesInv",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
