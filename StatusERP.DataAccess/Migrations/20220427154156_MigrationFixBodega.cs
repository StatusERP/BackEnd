using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class MigrationFixBodega : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bodegas_Sucursales_SucursalId",
                schema: "H2C",
                table: "Bodegas");

            migrationBuilder.DropIndex(
                name: "IX_Bodegas_SucursalId",
                schema: "H2C",
                table: "Bodegas");

            migrationBuilder.DropColumn(
                name: "SucursalId",
                schema: "H2C",
                table: "Bodegas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SucursalId",
                schema: "H2C",
                table: "Bodegas",
                type: "int",
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
