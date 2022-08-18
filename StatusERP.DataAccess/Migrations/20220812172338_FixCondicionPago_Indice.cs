using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixCondicionPago_Indice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IxCodCondicionPago",
                schema: "H2C",
                table: "CondicionesPago",
                column: "CodCondicionPago",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IxCodCondicionPago",
                schema: "H2C",
                table: "CondicionesPago");
        }
    }
}
