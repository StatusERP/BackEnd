using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixRuta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IxCodRuta",
                schema: "H2C",
                table: "Rutas",
                column: "CodRuta",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IxCodRuta",
                schema: "H2C",
                table: "Rutas");
        }
    }
}
