using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixArticulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UnidadVenta",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6);

            migrationBuilder.AlterColumn<int>(
                name: "UnidadEmpaque",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6);

            migrationBuilder.AlterColumn<int>(
                name: "UnidadAlmacen",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6);

            migrationBuilder.AlterColumn<int>(
                name: "Impuesto",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<int>(
                name: "Clasificacion6",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Clasificacion5",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Clasificacion4",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Clasificacion3",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Clasificacion2",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Clasificacion1",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

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

            migrationBuilder.AddColumn<int>(
                name: "ImpuestoFKId",
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

            migrationBuilder.AddColumn<int>(
                name: "UnidadEmpaqueFKId",
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

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_ImpuestoFKId",
                schema: "H2C",
                table: "Articulos",
                column: "ImpuestoFKId");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_UnidadAlmacenFKId",
                schema: "H2C",
                table: "Articulos",
                column: "UnidadAlmacenFKId");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_UnidadEmpaqueFKId",
                schema: "H2C",
                table: "Articulos",
                column: "UnidadEmpaqueFKId");

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
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_ClasificacionesInv_ClasifInv2Id",
                schema: "H2C",
                table: "Articulos",
                column: "ClasifInv2Id",
                principalSchema: "H2C",
                principalTable: "ClasificacionesInv",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_ClasificacionesInv_ClasifInv3Id",
                schema: "H2C",
                table: "Articulos",
                column: "ClasifInv3Id",
                principalSchema: "H2C",
                principalTable: "ClasificacionesInv",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_ClasificacionesInv_ClasifInv4Id",
                schema: "H2C",
                table: "Articulos",
                column: "ClasifInv4Id",
                principalSchema: "H2C",
                principalTable: "ClasificacionesInv",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_ClasificacionesInv_ClasifInv5Id",
                schema: "H2C",
                table: "Articulos",
                column: "ClasifInv5Id",
                principalSchema: "H2C",
                principalTable: "ClasificacionesInv",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_ClasificacionesInv_ClasifInv6Id",
                schema: "H2C",
                table: "Articulos",
                column: "ClasifInv6Id",
                principalSchema: "H2C",
                principalTable: "ClasificacionesInv",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_Impuestos_ImpuestoFKId",
                schema: "H2C",
                table: "Articulos",
                column: "ImpuestoFKId",
                principalSchema: "H2C",
                principalTable: "Impuestos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_UnidadesMedida_UnidadVentaFKId",
                schema: "H2C",
                table: "Articulos",
                column: "UnidadVentaFKId",
                principalSchema: "H2C",
                principalTable: "UnidadesMedida",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_Impuestos_ImpuestoFKId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_UnidadesMedida_UnidadAlmacenFKId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_UnidadesMedida_UnidadEmpaqueFKId",
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

            migrationBuilder.DropIndex(
                name: "IX_Articulos_ImpuestoFKId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_UnidadAlmacenFKId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_UnidadEmpaqueFKId",
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

            migrationBuilder.DropColumn(
                name: "ImpuestoFKId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "UnidadAlmacenFKId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "UnidadEmpaqueFKId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "UnidadVentaFKId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.AlterColumn<string>(
                name: "UnidadVenta",
                schema: "H2C",
                table: "Articulos",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UnidadEmpaque",
                schema: "H2C",
                table: "Articulos",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UnidadAlmacen",
                schema: "H2C",
                table: "Articulos",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Impuesto",
                schema: "H2C",
                table: "Articulos",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Clasificacion6",
                schema: "H2C",
                table: "Articulos",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Clasificacion5",
                schema: "H2C",
                table: "Articulos",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Clasificacion4",
                schema: "H2C",
                table: "Articulos",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Clasificacion3",
                schema: "H2C",
                table: "Articulos",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Clasificacion2",
                schema: "H2C",
                table: "Articulos",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Clasificacion1",
                schema: "H2C",
                table: "Articulos",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
