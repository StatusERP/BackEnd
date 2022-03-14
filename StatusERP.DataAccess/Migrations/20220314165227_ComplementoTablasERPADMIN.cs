using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class ComplementoTablasERPADMIN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AjustesSubTipo",
                schema: "H2C",
                table: "AjustesSubTipo");

            migrationBuilder.RenameColumn(
                name: "Subtipo",
                schema: "H2C",
                table: "AjustesSubTipo",
                newName: "SubTipo");

            migrationBuilder.AlterColumn<string>(
                name: "AjusteConfig",
                schema: "H2C",
                table: "AjustesSubTipo",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "SubTipo",
                schema: "H2C",
                table: "AjustesSubTipo",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AjustesSubTipo",
                schema: "H2C",
                table: "AjustesSubTipo",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "BitacoraProceso",
                schema: "ERPADMIN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LlaveBitProceso = table.Column<int>(type: "int", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Compania = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estacion = table.Column<string>(type: "nvarchar(270)", maxLength: 270, nullable: false),
                    Proceso = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BitacoraProceso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Favoritos",
                schema: "ERPADMIN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accion = table.Column<int>(type: "int", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Posicion = table.Column<int>(type: "int", nullable: true),
                    AccionModulo = table.Column<int>(type: "int", nullable: false),
                    Padre = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favoritos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locks",
                schema: "ERPADMIN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Llave = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ConnectionId = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModuloInstalado",
                schema: "ERPADMIN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Conjunto = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Accion = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuloInstalado", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BitacoraProceso",
                schema: "ERPADMIN");

            migrationBuilder.DropTable(
                name: "Favoritos",
                schema: "ERPADMIN");

            migrationBuilder.DropTable(
                name: "Locks",
                schema: "ERPADMIN");

            migrationBuilder.DropTable(
                name: "ModuloInstalado",
                schema: "ERPADMIN");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AjustesSubTipo",
                schema: "H2C",
                table: "AjustesSubTipo");

            migrationBuilder.RenameColumn(
                name: "SubTipo",
                schema: "H2C",
                table: "AjustesSubTipo",
                newName: "Subtipo");

            migrationBuilder.AlterColumn<int>(
                name: "Subtipo",
                schema: "H2C",
                table: "AjustesSubTipo",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<int>(
                name: "AjusteConfig",
                schema: "H2C",
                table: "AjustesSubTipo",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AjustesSubTipo",
                schema: "H2C",
                table: "AjustesSubTipo",
                columns: new[] { "Id", "Subtipo" });
        }
    }
}
