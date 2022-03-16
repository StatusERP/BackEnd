using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixModuloInstalado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "ValorAdicional",
                schema: "ERPADMIN",
                table: "ModuloInstalado",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
