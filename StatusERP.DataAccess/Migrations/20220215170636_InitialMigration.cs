using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conjuntos",
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
                    VersionInstalad = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    NIT = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PAIS = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UsaSucursales = table.Column<bool>(type: "bit", nullable: false),
                    MascaraSucursal = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DireccionWeb = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CorreoDocEletronico = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NumeroRegistro = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ActividadComercial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgentePerseccion = table.Column<bool>(type: "bit", nullable: false),
                    CalPerscVentas = table.Column<bool>(type: "bit", nullable: false),
                    AgenteRetencionn = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createby = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updateby = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
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
                name: "Conjuntos");
        }
    }
}
