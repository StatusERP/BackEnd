using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class MigFix5ClasificacionCRV : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnidadMedida",
                schema: "H2C",
                table: "ClasificacionesInv");

            migrationBuilder.AddColumn<int>(
                name: "UnidadMedidaId",
                schema: "H2C",
                table: "ClasificacionesInv",
                type: "int",
                maxLength: 6,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ClasificacionesInv_UnidadMedidaId",
                schema: "H2C",
                table: "ClasificacionesInv",
                column: "UnidadMedidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClasificacionesInv_UnidadesMedida_UnidadMedidaId",
                schema: "H2C",
                table: "ClasificacionesInv",
                column: "UnidadMedidaId",
                principalSchema: "H2C",
                principalTable: "UnidadesMedida",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClasificacionesInv_UnidadesMedida_UnidadMedidaId",
                schema: "H2C",
                table: "ClasificacionesInv");

            migrationBuilder.DropIndex(
                name: "IX_ClasificacionesInv_UnidadMedidaId",
                schema: "H2C",
                table: "ClasificacionesInv");

            migrationBuilder.DropColumn(
                name: "UnidadMedidaId",
                schema: "H2C",
                table: "ClasificacionesInv");

            migrationBuilder.AddColumn<string>(
                name: "UnidadMedida",
                schema: "H2C",
                table: "ClasificacionesInv",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                defaultValue: "");
        }
    }
}
