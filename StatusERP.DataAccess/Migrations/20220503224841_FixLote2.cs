using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixLote2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Articulo",
                schema: "H2C",
                table: "Lotes");

            migrationBuilder.AddColumn<int>(
                name: "ArticuloId",
                schema: "H2C",
                table: "Lotes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArticuloId",
                schema: "H2C",
                table: "Lotes");

            migrationBuilder.AddColumn<string>(
                name: "Articulo",
                schema: "H2C",
                table: "Lotes",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }
    }
}
