using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class Fix_DocumentoInv_PaqueteId2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosInvDet_PaquetesInv_PaqueteInventarioId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "PaqueteInventarioId",
                principalSchema: "H2C",
                principalTable: "PaquetesInv",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosInvDet_PaquetesInv_PaqueteInventarioId",
                schema: "H2C",
                table: "DocumentosInvDet");
        }
    }
}
