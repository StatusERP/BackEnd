using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class CorrecionFKEntidadFinanciera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NIT",
                schema: "DEMO",
                table: "EntidadesFinancieras");

            migrationBuilder.AddColumn<int>(
                name: "DocTributarioId",
                schema: "DEMO",
                table: "EntidadesFinancieras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EntidadesFinancieras_DocTributarioId",
                schema: "DEMO",
                table: "EntidadesFinancieras",
                column: "DocTributarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_EntidadesFinancieras_DocTributarios_DocTributarioId",
                schema: "DEMO",
                table: "EntidadesFinancieras",
                column: "DocTributarioId",
                principalSchema: "DEMO",
                principalTable: "DocTributarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntidadesFinancieras_DocTributarios_DocTributarioId",
                schema: "DEMO",
                table: "EntidadesFinancieras");

            migrationBuilder.DropIndex(
                name: "IX_EntidadesFinancieras_DocTributarioId",
                schema: "DEMO",
                table: "EntidadesFinancieras");

            migrationBuilder.DropColumn(
                name: "DocTributarioId",
                schema: "DEMO",
                table: "EntidadesFinancieras");

            migrationBuilder.AddColumn<string>(
                name: "NIT",
                schema: "DEMO",
                table: "EntidadesFinancieras",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }
    }
}
