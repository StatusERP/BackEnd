using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class CorrecionFKBodega : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bodegas_Sucursales_SucursalId",
                schema: "H2C",
                table: "Bodegas");

            migrationBuilder.DropColumn(
                name: "CodSucursal",
                schema: "H2C",
                table: "Bodegas");

            migrationBuilder.AlterColumn<int>(
                name: "SucursalId",
                schema: "H2C",
                table: "Bodegas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Bodegas_Sucursales_SucursalId",
                schema: "H2C",
                table: "Bodegas",
                column: "SucursalId",
                principalSchema: "H2C",
                principalTable: "Sucursales",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bodegas_Sucursales_SucursalId",
                schema: "H2C",
                table: "Bodegas");

            migrationBuilder.AlterColumn<int>(
                name: "SucursalId",
                schema: "H2C",
                table: "Bodegas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodSucursal",
                schema: "H2C",
                table: "Bodegas",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bodegas_Sucursales_SucursalId",
                schema: "H2C",
                table: "Bodegas",
                column: "SucursalId",
                principalSchema: "H2C",
                principalTable: "Sucursales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
