using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixMoneda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IxCodMoneda",
                schema: "H2C",
                table: "Monedas",
                column: "CodMoneda",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IxCodMoneda",
                schema: "H2C",
                table: "Monedas");
        }
    }
}
