using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixGlobCI2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoAsiento",
                schema: "H2C",
                table: "GlobalesCI",
                newName: "TipoAsientoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoAsientoId",
                schema: "H2C",
                table: "GlobalesCI",
                newName: "TipoAsiento");
        }
    }
}
