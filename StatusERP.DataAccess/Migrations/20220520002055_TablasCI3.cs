using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class TablasCI3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Consecutivo",
                schema: "H2C",
                table: "DocumentosInvEnc");

            migrationBuilder.DropColumn(
                name: "AjusteConfig",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "Articulo",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "Bodega",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "BodegaDestino",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "CentroCosto",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "CuentaContable",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "DocTributario",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "LocalizacionDest",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "Localización",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "Lote",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "TipoOperacion",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "TipoPago",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "UnidadDistribucio",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.RenameColumn(
                name: "SerieCadena",
                schema: "H2C",
                table: "DocumentosInvDet",
                newName: "UnidadDistribucionId");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioApro",
                schema: "H2C",
                table: "DocumentosInvEnc",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Usuario",
                schema: "H2C",
                table: "DocumentosInvEnc",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AddColumn<int>(
                name: "ConsecutivoId",
                schema: "H2C",
                table: "DocumentosInvEnc",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AjusteConfigId",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArticuloId",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BodegaDestinoId",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BodegaId",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CentroCuentaId",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DocTributarioId",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocDestinoId",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocalizacionId",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LoteId",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoOperacionId",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoPagoId",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosInvEnc_ConsecutivoId",
                schema: "H2C",
                table: "DocumentosInvEnc",
                column: "ConsecutivoId");

            migrationBuilder.CreateIndex(
                name: "IxDocInvEnc_PaqDoc",
                schema: "H2C",
                table: "DocumentosInvEnc",
                columns: new[] { "PaqueteInventario", "DocumentoInv" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosInvDet_AjusteConfigId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "AjusteConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosInvDet_ArticuloId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosInvDet_BodegaDestinoId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "BodegaDestinoId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosInvDet_BodegaId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "BodegaId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosInvDet_CentroCuentaId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "CentroCuentaId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosInvDet_DocTributarioId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "DocTributarioId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosInvDet_LocalizacionId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "LocalizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosInvDet_LocDestinoId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "LocDestinoId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosInvDet_LoteId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "LoteId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosInvDet_TipoOperacionId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "TipoOperacionId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosInvDet_TipoPagoId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "TipoPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentosInvDet_UnidadDistribucionId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "UnidadDistribucionId");

            migrationBuilder.CreateIndex(
                name: "IxDocInvDet_PaqDocLin",
                schema: "H2C",
                table: "DocumentosInvDet",
                columns: new[] { "PaqueteInventario", "DocumentoInv", "LineaDocInv" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosInvDet_AjustesConfig_AjusteConfigId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "AjusteConfigId",
                principalSchema: "H2C",
                principalTable: "AjustesConfig",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosInvDet_Articulos_ArticuloId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "ArticuloId",
                principalSchema: "H2C",
                principalTable: "Articulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosInvDet_Bodegas_BodegaDestinoId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "BodegaDestinoId",
                principalSchema: "H2C",
                principalTable: "Bodegas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosInvDet_Bodegas_BodegaId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "BodegaId",
                principalSchema: "H2C",
                principalTable: "Bodegas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosInvDet_CentroCuenta_CentroCuentaId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "CentroCuentaId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosInvDet_DocTributarios_DocTributarioId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "DocTributarioId",
                principalSchema: "H2C",
                principalTable: "DocTributarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosInvDet_Localizaciones_LocalizacionId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "LocalizacionId",
                principalSchema: "H2C",
                principalTable: "Localizaciones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosInvDet_Localizaciones_LocDestinoId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "LocDestinoId",
                principalSchema: "H2C",
                principalTable: "Localizaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosInvDet_Lotes_LoteId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "LoteId",
                principalSchema: "H2C",
                principalTable: "Lotes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosInvDet_TiposOperacion_TipoOperacionId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "TipoOperacionId",
                principalSchema: "H2C",
                principalTable: "TiposOperacion",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosInvDet_TiposPago_TipoPagoId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "TipoPagoId",
                principalSchema: "H2C",
                principalTable: "TiposPago",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosInvDet_UnidadesMedida_UnidadDistribucionId",
                schema: "H2C",
                table: "DocumentosInvDet",
                column: "UnidadDistribucionId",
                principalSchema: "H2C",
                principalTable: "UnidadesMedida",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentosInvEnc_ConsecutivosInv_ConsecutivoId",
                schema: "H2C",
                table: "DocumentosInvEnc",
                column: "ConsecutivoId",
                principalSchema: "H2C",
                principalTable: "ConsecutivosInv",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosInvDet_AjustesConfig_AjusteConfigId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosInvDet_Articulos_ArticuloId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosInvDet_Bodegas_BodegaDestinoId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosInvDet_Bodegas_BodegaId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosInvDet_CentroCuenta_CentroCuentaId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosInvDet_DocTributarios_DocTributarioId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosInvDet_Localizaciones_LocalizacionId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosInvDet_Localizaciones_LocDestinoId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosInvDet_Lotes_LoteId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosInvDet_TiposOperacion_TipoOperacionId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosInvDet_TiposPago_TipoPagoId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosInvDet_UnidadesMedida_UnidadDistribucionId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentosInvEnc_ConsecutivosInv_ConsecutivoId",
                schema: "H2C",
                table: "DocumentosInvEnc");

            migrationBuilder.DropIndex(
                name: "IX_DocumentosInvEnc_ConsecutivoId",
                schema: "H2C",
                table: "DocumentosInvEnc");

            migrationBuilder.DropIndex(
                name: "IxDocInvEnc_PaqDoc",
                schema: "H2C",
                table: "DocumentosInvEnc");

            migrationBuilder.DropIndex(
                name: "IX_DocumentosInvDet_AjusteConfigId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropIndex(
                name: "IX_DocumentosInvDet_ArticuloId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropIndex(
                name: "IX_DocumentosInvDet_BodegaDestinoId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropIndex(
                name: "IX_DocumentosInvDet_BodegaId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropIndex(
                name: "IX_DocumentosInvDet_CentroCuentaId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropIndex(
                name: "IX_DocumentosInvDet_DocTributarioId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropIndex(
                name: "IX_DocumentosInvDet_LocalizacionId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropIndex(
                name: "IX_DocumentosInvDet_LocDestinoId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropIndex(
                name: "IX_DocumentosInvDet_LoteId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropIndex(
                name: "IX_DocumentosInvDet_TipoOperacionId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropIndex(
                name: "IX_DocumentosInvDet_TipoPagoId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropIndex(
                name: "IX_DocumentosInvDet_UnidadDistribucionId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropIndex(
                name: "IxDocInvDet_PaqDocLin",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "ConsecutivoId",
                schema: "H2C",
                table: "DocumentosInvEnc");

            migrationBuilder.DropColumn(
                name: "AjusteConfigId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "ArticuloId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "BodegaDestinoId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "BodegaId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "CentroCuentaId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "DocTributarioId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "LocDestinoId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "LocalizacionId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "LoteId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "TipoOperacionId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.DropColumn(
                name: "TipoPagoId",
                schema: "H2C",
                table: "DocumentosInvDet");

            migrationBuilder.RenameColumn(
                name: "UnidadDistribucionId",
                schema: "H2C",
                table: "DocumentosInvDet",
                newName: "SerieCadena");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioApro",
                schema: "H2C",
                table: "DocumentosInvEnc",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Usuario",
                schema: "H2C",
                table: "DocumentosInvEnc",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AddColumn<string>(
                name: "Consecutivo",
                schema: "H2C",
                table: "DocumentosInvEnc",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AjusteConfig",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Articulo",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Bodega",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BodegaDestino",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CentroCosto",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CuentaContable",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocTributario",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocalizacionDest",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Localización",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lote",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoOperacion",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoPago",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UnidadDistribucio",
                schema: "H2C",
                table: "DocumentosInvDet",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true);
        }
    }
}
