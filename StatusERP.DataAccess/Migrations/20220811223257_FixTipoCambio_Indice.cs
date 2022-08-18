using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixTipoCambio_Indice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IxCodTipoCambio",
                schema: "H2C",
                table: "TiposCambio",
                column: "CodTipoCambio",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IxCodTipoCambio",
                schema: "H2C",
                table: "TiposCambio");
        }
    }
}
