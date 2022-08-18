using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class Fix_DocumentoInvDet_DocumentoId2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosInvDet_DocumentosInvEnc_documentoInvEncId",
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

            migrationBuilder.RenameColumn(
                name: "documentoInvEncId",
                schema: "H2C",
                table: "DocumentosInvDet",
                newName: "DocumentoInvEncId");

            migrationBuilder.RenameIndex(
                name: "IX_DocumentosInvDet_documentoInvEncId",
                schema: "H2C",
                table: "DocumentosInvDet",
                newName: "IX_DocumentosInvDet_DocumentoInvEncId");

            migrationBuilder.CreateIndex(
                name: "IxDocInvDet_PaqDocLin",
                schema: "H2C",
                table: "DocumentosInvDet",
                columns: new[] { "PaqueteInventarioId", "DocumentoInvEncId", "LineaDocInv" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosInvDet_DocumentosInvEnc_DocumentoInvEncId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "DocumentoInvEncId",
                principalSchema: "H2C",
                principalTable: "DocumentosInvEnc",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosInvDet_DocumentosInvEnc_DocumentoInvEncId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropIndex(
                name: "IxDocInvDet_PaqDocLin",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.RenameColumn(
                name: "DocumentoInvEncId",
                schema: "H2C",
                table: "DocumentosInvDet",
                newName: "documentoInvEncId");

            migrationBuilder.RenameIndex(
                name: "IX_DocumentosInvDet_DocumentoInvEncId",
                schema: "H2C",
                table: "DocumentosInvDet",
                newName: "IX_DocumentosInvDet_documentoInvEncId");

            migrationBuilder.AddColumn<int>(
                name: "DocumentoInvId",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                onDelete: ReferentialAction.Cascade);
        }
    }
}
