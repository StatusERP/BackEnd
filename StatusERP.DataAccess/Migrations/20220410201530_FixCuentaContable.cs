using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixCuentaContable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UltimoAsientoCorp",
                schema: "H2C",
                table: "PaquetesContables");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UltimoAsientoCorp",
                schema: "H2C",
                table: "PaquetesContables",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);
        }
    }
}
