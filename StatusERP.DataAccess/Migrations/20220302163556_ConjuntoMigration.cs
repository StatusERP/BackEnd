using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class ConjuntoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ERPADMIN");

            migrationBuilder.CreateTable(
                name: "Conjuntos",
                schema: "ERPADMIN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Conjunto = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DobleMoneda = table.Column<bool>(type: "bit", nullable: false),
                    DobleContabilidad = table.Column<bool>(type: "bit", nullable: false),
                    UsaLotes = table.Column<bool>(type: "bit", nullable: false),
                    UsaCentroCosto = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioUltMod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaUltMod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VersionBD = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    UsuarioModBd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaHoraModBd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VersionInstalada = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    DocTributario = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UsaSucursales = table.Column<bool>(type: "bit", nullable: false),
                    MascaraSucursal = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DireccionWeb = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CorreoDocElectronico = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NumeroRegistro = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ActividadComercial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentePercepcion = table.Column<bool>(type: "bit", nullable: false),
                    CalPercepVentas = table.Column<bool>(type: "bit", nullable: false),
                    AgenteRetencion = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conjuntos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conjuntos",
                schema: "ERPADMIN");
        }
    }
}
