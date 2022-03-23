using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class Fix4GlobalesAS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Moneda",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.AddColumn<string>(
                name: "MonedaLocal",
                schema: "H2C",
                table: "GlobalesAS",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MonedaLocal",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.AddColumn<int>(
                name: "Moneda",
                schema: "H2C",
                table: "GlobalesAS",
                type: "int",
                maxLength: 4,
                nullable: false,
                defaultValue: 0);
        }
    }
}
