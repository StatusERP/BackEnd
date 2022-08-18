using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class CreateTablaDireccion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosInvDet_Localizaciones_LocalizacionId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "Contribuyente",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.AlterColumn<int>(
                name: "LocalizacionId",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContribuyenteId",
                schema: "H2C",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DocTributarioId",
                schema: "H2C",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Direcciones",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodDireccion = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    NombreCampo01 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NombreCampo02 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NombreCampo03 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NombreCampo04 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NombreCampo05 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NombreCampo06 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NombreCampo07 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NombreCampo08 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NombreCampo09 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NombreCampo10 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direcciones", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_DocTributarioId",
                schema: "H2C",
                table: "Clientes",
                column: "DocTributarioId");

            migrationBuilder.CreateIndex(
                name: "IxCodDireccion",
                schema: "H2C",
                table: "Direcciones",
                column: "CodDireccion",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_DocTributarios_DocTributarioId",
                schema: "H2C",
                table: "Clientes",
                column: "DocTributarioId",
                principalSchema: "H2C",
                principalTable: "DocTributarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosInvDet_Localizaciones_LocalizacionId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "LocalizacionId",
                principalSchema: "H2C",
                principalTable: "Localizaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_DocTributarios_DocTributarioId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosInvDet_Localizaciones_LocalizacionId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropTable(
                name: "Direcciones",
                schema: "H2C");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_DocTributarioId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ContribuyenteId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "DocTributarioId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.AlterColumn<int>(
                name: "LocalizacionId",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Contribuyente",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosInvDet_Localizaciones_LocalizacionId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "LocalizacionId",
                principalSchema: "H2C",
                principalTable: "Localizaciones",
                principalColumn: "Id");
        }
    }
}
