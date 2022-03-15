using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixModuloInstalado2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorAdicional",
                schema: "ERPADMIN",
                table: "ModuloInstalado");

            migrationBuilder.AddColumn<int>(
                name: "AccionId",
                schema: "ERPADMIN",
                table: "ModuloInstalado",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ModuloInstalado_AccionId",
                schema: "ERPADMIN",
                table: "ModuloInstalado",
                column: "AccionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ModuloInstalado_Accion_AccionId",
                schema: "ERPADMIN",
                table: "ModuloInstalado",
                column: "AccionId",
                principalSchema: "ERPADMIN",
                principalTable: "Accion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModuloInstalado_Accion_AccionId",
                schema: "ERPADMIN",
                table: "ModuloInstalado");

            migrationBuilder.DropIndex(
                name: "IX_ModuloInstalado_AccionId",
                schema: "ERPADMIN",
                table: "ModuloInstalado");

            migrationBuilder.DropColumn(
                name: "AccionId",
                schema: "ERPADMIN",
                table: "ModuloInstalado");

            migrationBuilder.AddColumn<string>(
                name: "ValorAdicional",
                schema: "ERPADMIN",
                table: "ModuloInstalado",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
