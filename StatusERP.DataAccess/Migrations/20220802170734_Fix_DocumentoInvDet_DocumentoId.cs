using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class Fix_DocumentoInvDet_DocumentoId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IxDocInvDet_PaqDocLin",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "DocumentoInv",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.AddColumn<int>(
                name: "DocumentoInvId",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "documentoInvEncId",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosInvDet_documentoInvEncId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "documentoInvEncId");

            migrationBuilder.CreateIndex(
                name: "IxDocInvDet_PaqDocLin",
                schema: "H2C",
                table: "DocumentosInvDet",
                columns: new[] { "PaqueteInventarioId", "DocumentoInvId", "LineaDocInv" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosInvDet_DocumentosInvEnc_documentoInvEncId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "documentoInvEncId",
                principalSchema: "H2C",
                principalTable: "DocumentosInvEnc",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosInvDet_DocumentosInvEnc_documentoInvEncId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropIndex(
                name: "IX_DocumentosInvDet_documentoInvEncId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropIndex(
                name: "IxDocInvDet_PaqDocLin",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "DocumentoInvId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "documentoInvEncId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.AddColumn<string>(
                name: "DocumentoInv",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IxDocInvDet_PaqDocLin",
                schema: "H2C",
                table: "DocumentosInvDet",
                columns: new[] { "PaqueteInventarioId", "DocumentoInv", "LineaDocInv" },
                unique: true);
        }
    }
}
