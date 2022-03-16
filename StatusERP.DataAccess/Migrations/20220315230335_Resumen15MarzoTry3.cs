using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class Resumen15MarzoTry3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GlobalesCI",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CostosDec = table.Column<short>(type: "smallint", nullable: false),
                    ExistenciasDec = table.Column<short>(type: "smallint", nullable: false),
                    PesosDec = table.Column<short>(type: "smallint", nullable: false),
                    Costo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CostoIngrDefault = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnidadPeso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnidadVolumen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsaLocalizacion = table.Column<bool>(type: "bit", nullable: false),
                    AjustarConteo = table.Column<bool>(type: "bit", nullable: false),
                    MaxAuditoria = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalesCI", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GlobalesCI",
                schema: "H2C");
        }
    }
}
