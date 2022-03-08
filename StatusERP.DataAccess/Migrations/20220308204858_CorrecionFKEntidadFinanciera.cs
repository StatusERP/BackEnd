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
                schema: "H2C",
                table: "EntidadesFinancieras");

            migrationBuilder.AddColumn<int>(
                name: "DocTributarioId",
                schema: "H2C",
                table: "EntidadesFinancieras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EntidadesFinancieras_DocTributarioId",
                schema: "H2C",
                table: "EntidadesFinancieras",
                column: "DocTributarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_EntidadesFinancieras_DocTributarios_DocTributarioId",
                schema: "H2C",
                table: "EntidadesFinancieras",
                column: "DocTributarioId",
                principalSchema: "H2C",
                principalTable: "DocTributarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntidadesFinancieras_DocTributarios_DocTributarioId",
                schema: "H2C",
                table: "EntidadesFinancieras");

            migrationBuilder.DropIndex(
                name: "IX_EntidadesFinancieras_DocTributarioId",
                schema: "H2C",
                table: "EntidadesFinancieras");

            migrationBuilder.DropColumn(
                name: "DocTributarioId",
                schema: "H2C",
                table: "EntidadesFinancieras");

            migrationBuilder.AddColumn<string>(
                name: "NIT",
                schema: "H2C",
                table: "EntidadesFinancieras",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }
    }
}
