using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixMovInvDet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovsInventarioDet_UnidadesMedida_unidadMedidaId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropIndex(
                name: "IX_MovsInventarioDet_unidadMedidaId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropColumn(
                name: "TipoOperacion",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropColumn(
                name: "TipoPago",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.RenameColumn(
                name: "unidadMedidaId",
                schema: "H2C",
                table: "MovsInventarioDet",
                newName: "MovInventarioEncId");

            migrationBuilder.RenameColumn(
                name: "UnidadDistribucion",
                schema: "H2C",
                table: "MovsInventarioDet",
                newName: "UnidadDistribucionId");

            migrationBuilder.AddColumn<int>(
                name: "TipoOperacionId",
                schema: "H2C",
                table: "MovsInventarioDet",
                type: "int",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoPagoId",
                schema: "H2C",
                table: "MovsInventarioDet",
                type: "int",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MovsInventarioDet_TipoOperacionId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "TipoOperacionId");

            migrationBuilder.CreateIndex(
                name: "IX_MovsInventarioDet_TipoPagoId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "TipoPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_MovsInventarioDet_UnidadDistribucionId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "UnidadDistribucionId");

            migrationBuilder.CreateIndex(
                name: "IxMovInvEnc_Consec",
                schema: "H2C",
                table: "MovsInventarioDet",
                columns: new[] { "MovInventarioEncId", "Consecutivo" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IxLoteArticulo",
                schema: "H2C",
                table: "Lotes",
                columns: new[] { "CodLote", "ArticuloId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MovsInventarioDet_MovsInventarioEnc_MovInventarioEncId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "MovInventarioEncId",
                principalSchema: "H2C",
                principalTable: "MovsInventarioEnc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovsInventarioDet_TiposOperacion_TipoOperacionId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "TipoOperacionId",
                principalSchema: "H2C",
                principalTable: "TiposOperacion",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovsInventarioDet_TiposPago_TipoPagoId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "TipoPagoId",
                principalSchema: "H2C",
                principalTable: "TiposPago",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovsInventarioDet_UnidadesMedida_UnidadDistribucionId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "UnidadDistribucionId",
                principalSchema: "H2C",
                principalTable: "UnidadesMedida",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovsInventarioDet_MovsInventarioEnc_MovInventarioEncId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropForeignKey(
                name: "FK_MovsInventarioDet_TiposOperacion_TipoOperacionId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropForeignKey(
                name: "FK_MovsInventarioDet_TiposPago_TipoPagoId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropForeignKey(
                name: "FK_MovsInventarioDet_UnidadesMedida_UnidadDistribucionId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropIndex(
                name: "IX_MovsInventarioDet_TipoOperacionId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropIndex(
                name: "IX_MovsInventarioDet_TipoPagoId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropIndex(
                name: "IX_MovsInventarioDet_UnidadDistribucionId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropIndex(
                name: "IxMovInvEnc_Consec",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropIndex(
                name: "IxLoteArticulo",
                schema: "H2C",
                table: "Lotes");

            migrationBuilder.DropColumn(
                name: "TipoOperacionId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropColumn(
                name: "TipoPagoId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.RenameColumn(
                name: "UnidadDistribucionId",
                schema: "H2C",
                table: "MovsInventarioDet",
                newName: "UnidadDistribucion");

            migrationBuilder.RenameColumn(
                name: "MovInventarioEncId",
                schema: "H2C",
                table: "MovsInventarioDet",
                newName: "unidadMedidaId");

            migrationBuilder.AddColumn<string>(
                name: "TipoOperacion",
                schema: "H2C",
                table: "MovsInventarioDet",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoPago",
                schema: "H2C",
                table: "MovsInventarioDet",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MovsInventarioDet_unidadMedidaId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "unidadMedidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovsInventarioDet_UnidadesMedida_unidadMedidaId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "unidadMedidaId",
                principalSchema: "H2C",
                principalTable: "UnidadesMedida",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
