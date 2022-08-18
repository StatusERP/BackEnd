using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class Fix_AjusteSubTipo_AjusteSubSubTipo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AjusteConfigId",
                schema: "H2C",
                table: "AjustesSubTipo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AjusteConfigId",
                schema: "H2C",
                table: "AjustesSubSubTipo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AjustesSubTipo_AjusteConfigId",
                schema: "H2C",
                table: "AjustesSubTipo",
                column: "AjusteConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_AjustesSubSubTipo_AjusteConfigId",
                schema: "H2C",
                table: "AjustesSubSubTipo",
                column: "AjusteConfigId");

            migrationBuilder.AddForeignKey(
                name: "FK_AjustesSubSubTipo_AjustesConfig_AjusteConfigId",
                schema: "H2C",
                table: "AjustesSubSubTipo",
                column: "AjusteConfigId",
                principalSchema: "H2C",
                principalTable: "AjustesConfig",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AjustesSubTipo_AjustesConfig_AjusteConfigId",
                schema: "H2C",
                table: "AjustesSubTipo",
                column: "AjusteConfigId",
                principalSchema: "H2C",
                principalTable: "AjustesConfig",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AjustesSubSubTipo_AjustesConfig_AjusteConfigId",
                schema: "H2C",
                table: "AjustesSubSubTipo");

            migrationBuilder.DropForeignKey(
                name: "FK_AjustesSubTipo_AjustesConfig_AjusteConfigId",
                schema: "H2C",
                table: "AjustesSubTipo");

            migrationBuilder.DropIndex(
                name: "IX_AjustesSubTipo_AjusteConfigId",
                schema: "H2C",
                table: "AjustesSubTipo");

            migrationBuilder.DropIndex(
                name: "IX_AjustesSubSubTipo_AjusteConfigId",
                schema: "H2C",
                table: "AjustesSubSubTipo");

            migrationBuilder.DropColumn(
                name: "AjusteConfigId",
                schema: "H2C",
                table: "AjustesSubTipo");

            migrationBuilder.DropColumn(
                name: "AjusteConfigId",
                schema: "H2C",
                table: "AjustesSubSubTipo");
        }
    }
}
