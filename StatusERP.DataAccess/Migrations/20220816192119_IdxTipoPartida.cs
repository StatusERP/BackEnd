using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class IdxTipoPartida : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IxCodPartida",
                schema: "H2C",
                table: "TiposPartida",
                column: "CodTipoPartida",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IxCodPartida",
                schema: "H2C",
                table: "TiposPartida");
        }
    }
}
