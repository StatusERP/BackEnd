using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class AddIndexPadre_Parentesco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Costo",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "CostoIngrDefault",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.AlterColumn<string>(
                name: "UnidadVolumen",
                schema: "H2C",
                table: "GlobalesCI",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UnidadPeso",
                schema: "H2C",
                table: "GlobalesCI",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "AsntAjuCompra",
                schema: "H2C",
                table: "GlobalesCI",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AsntAjuConsumo",
                schema: "H2C",
                table: "GlobalesCI",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AsntAjuCosto",
                schema: "H2C",
                table: "GlobalesCI",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AsntAjuFisico",
                schema: "H2C",
                table: "GlobalesCI",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AsntAjuMiscelan",
                schema: "H2C",
                table: "GlobalesCI",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AsntAjuProduc",
                schema: "H2C",
                table: "GlobalesCI",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AsntAjuVencim",
                schema: "H2C",
                table: "GlobalesCI",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AsntAjuVenta",
                schema: "H2C",
                table: "GlobalesCI",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CtrEnTransaccion",
                schema: "H2C",
                table: "GlobalesCI",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ExistEnTotales",
                schema: "H2C",
                table: "GlobalesCI",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FchUltProcAprob",
                schema: "H2C",
                table: "GlobalesCI",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FchUltProcVcto",
                schema: "H2C",
                table: "GlobalesCI",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaInicioTrans",
                schema: "H2C",
                table: "GlobalesCI",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IntegracionConta",
                schema: "H2C",
                table: "GlobalesCI",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<short>(
                name: "ModAplicAsiento",
                schema: "H2C",
                table: "GlobalesCI",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<string>(
                name: "NombreClasif1",
                schema: "H2C",
                table: "GlobalesCI",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NombreClasif2",
                schema: "H2C",
                table: "GlobalesCI",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NombreClasif3",
                schema: "H2C",
                table: "GlobalesCI",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NombreClasif4",
                schema: "H2C",
                table: "GlobalesCI",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombreClasif5",
                schema: "H2C",
                table: "GlobalesCI",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombreClasif6",
                schema: "H2C",
                table: "GlobalesCI",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Paquete",
                schema: "H2C",
                table: "GlobalesCI",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoAsiento",
                schema: "H2C",
                table: "GlobalesCI",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IxPadre",
                schema: "ERPADMIN",
                table: "Parentesco",
                column: "Padre");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IxPadre",
                schema: "ERPADMIN",
                table: "Parentesco");

            migrationBuilder.DropColumn(
                name: "AsntAjuCompra",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "AsntAjuConsumo",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "AsntAjuCosto",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "AsntAjuFisico",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "AsntAjuMiscelan",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "AsntAjuProduc",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "AsntAjuVencim",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "AsntAjuVenta",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "CtrEnTransaccion",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "ExistEnTotales",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "FchUltProcAprob",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "FchUltProcVcto",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "FechaInicioTrans",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "IntegracionConta",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "ModAplicAsiento",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "NombreClasif1",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "NombreClasif2",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "NombreClasif3",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "NombreClasif4",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "NombreClasif5",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "NombreClasif6",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "Paquete",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "TipoAsiento",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.AlterColumn<string>(
                name: "UnidadVolumen",
                schema: "H2C",
                table: "GlobalesCI",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6);

            migrationBuilder.AlterColumn<string>(
                name: "UnidadPeso",
                schema: "H2C",
                table: "GlobalesCI",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6);

            migrationBuilder.AddColumn<string>(
                name: "Costo",
                schema: "H2C",
                table: "GlobalesCI",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CostoIngrDefault",
                schema: "H2C",
                table: "GlobalesCI",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
