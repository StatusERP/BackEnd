using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class Fix_DocumentoInv_PaqueteId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IxDocInvEnc_PaqDoc",
                schema: "H2C",
                table: "DocumentosInvEnc");

            migrationBuilder.DropIndex(
                name: "IxDocInvDet_PaqDocLin",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "PaqueteInventario",
                schema: "H2C",
                table: "DocumentosInvEnc");

            migrationBuilder.DropColumn(
                name: "PaqueteInventario",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.AddColumn<int>(
                name: "PaqueteInventarioId",
                schema: "H2C",
                table: "DocumentosInvEnc",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaqueteInventarioId",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IxDocInvEnc_PaqDoc",
                schema: "H2C",
                table: "DocumentosInvEnc",
                columns: new[] { "PaqueteInventarioId", "DocumentoInv" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IxDocInvDet_PaqDocLin",
                schema: "H2C",
                table: "DocumentosInvDet",
                columns: new[] { "PaqueteInventarioId", "DocumentoInv", "LineaDocInv" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosInvEnc_PaquetesInv_PaqueteInventarioId",
                schema: "H2C",
                table: "DocumentosInvEnc",
                column: "PaqueteInventarioId",
                principalSchema: "H2C",
                principalTable: "PaquetesInv",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosInvEnc_PaquetesInv_PaqueteInventarioId",
                schema: "H2C",
                table: "DocumentosInvEnc");

            migrationBuilder.DropIndex(
                name: "IxDocInvEnc_PaqDoc",
                schema: "H2C",
                table: "DocumentosInvEnc");

            migrationBuilder.DropIndex(
                name: "IxDocInvDet_PaqDocLin",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "PaqueteInventarioId",
                schema: "H2C",
                table: "DocumentosInvEnc");

            migrationBuilder.DropColumn(
                name: "PaqueteInventarioId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.AddColumn<string>(
                name: "PaqueteInventario",
                schema: "H2C",
                table: "DocumentosInvEnc",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaqueteInventario",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IxDocInvEnc_PaqDoc",
                schema: "H2C",
                table: "DocumentosInvEnc",
                columns: new[] { "PaqueteInventario", "DocumentoInv" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IxDocInvDet_PaqDocLin",
                schema: "H2C",
                table: "DocumentosInvDet",
                columns: new[] { "PaqueteInventario", "DocumentoInv", "LineaDocInv" },
                unique: true);
        }
    }
}
