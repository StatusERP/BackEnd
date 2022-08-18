using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class Fix_MovInvDet_NulabilidadBodegas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosInvDet_Bodegas_BodegaId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.AlterColumn<int>(
                name: "BodegaId",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosInvDet_Bodegas_BodegaId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "BodegaId",
                principalSchema: "H2C",
                principalTable: "Bodegas",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosInvDet_Bodegas_BodegaId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.AlterColumn<int>(
                name: "BodegaId",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosInvDet_Bodegas_BodegaId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "BodegaId",
                principalSchema: "H2C",
                principalTable: "Bodegas",
                principalColumn: "Id");
        }
    }
}
