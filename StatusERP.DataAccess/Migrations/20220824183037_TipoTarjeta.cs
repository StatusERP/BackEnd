using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class TipoTarjeta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TiposTarjeta",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodTipoTarjeta = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    TipoCobro = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    AssemblyInvocation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposTarjeta", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IxCodTipoTarjeta",
                schema: "H2C",
                table: "TiposTarjeta",
                column: "CodTipoTarjeta",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TiposTarjeta",
                schema: "H2C");
        }
    }
}
