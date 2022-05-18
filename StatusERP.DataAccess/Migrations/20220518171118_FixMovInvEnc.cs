using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixMovInvEnc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Consecutivo",
                schema: "H2C",
                table: "MovsInventarioEnc");

            migrationBuilder.AddColumn<int>(
                name: "ConsecutivoId",
                schema: "H2C",
                table: "MovsInventarioEnc",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MovsInventarioEnc_ConsecutivoId",
                schema: "H2C",
                table: "MovsInventarioEnc",
                column: "ConsecutivoId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovsInventarioEnc_ConsecutivosInv_ConsecutivoId",
                schema: "H2C",
                table: "MovsInventarioEnc",
                column: "ConsecutivoId",
                principalSchema: "H2C",
                principalTable: "ConsecutivosInv",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovsInventarioEnc_ConsecutivosInv_ConsecutivoId",
                schema: "H2C",
                table: "MovsInventarioEnc");

            migrationBuilder.DropIndex(
                name: "IX_MovsInventarioEnc_ConsecutivoId",
                schema: "H2C",
                table: "MovsInventarioEnc");

            migrationBuilder.DropColumn(
                name: "ConsecutivoId",
                schema: "H2C",
                table: "MovsInventarioEnc");

            migrationBuilder.AddColumn<string>(
                name: "Consecutivo",
                schema: "H2C",
                table: "MovsInventarioEnc",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);
        }
    }
}
