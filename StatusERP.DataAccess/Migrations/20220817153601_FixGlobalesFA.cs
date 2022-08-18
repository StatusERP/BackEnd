using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixGlobalesFA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BodegaDefault",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "CategoriaCliente",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "CondPagoContado",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "CtaDocumentaci",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "CtaFlete",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "CtaImpComisio",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "CtaImpuesto1",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "CtaImpuesto2",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "CtaSeguro",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "CtrConsumo",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "CtrDocumentanci",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "CtrFlete",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "CtrImpComisio",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "CtrImpuesto1",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "CtrImpuesto2",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "CtrSeguro",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "Llave",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "MonedaNivel",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "MonedaPublico",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "NivPrePublico",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "NivelPrecio",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "Paquete",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "TipoAsiento",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "TipoCambio",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.AddColumn<int>(
                name: "BodegaDefaultId",
                schema: "H2C",
                table: "GlobalesFA",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaClienteId",
                schema: "H2C",
                table: "GlobalesFA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CondPagoContadoId",
                schema: "H2C",
                table: "GlobalesFA",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrConsumoId",
                schema: "H2C",
                table: "GlobalesFA",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaDocumentacionId",
                schema: "H2C",
                table: "GlobalesFA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaFleteId",
                schema: "H2C",
                table: "GlobalesFA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaImpComisioId",
                schema: "H2C",
                table: "GlobalesFA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaImpuesto1Id",
                schema: "H2C",
                table: "GlobalesFA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaImpuesto2Id",
                schema: "H2C",
                table: "GlobalesFA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CtrCtaSeguroId",
                schema: "H2C",
                table: "GlobalesFA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NivelPrecioId",
                schema: "H2C",
                table: "GlobalesFA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NivelPrecioPublicoId",
                schema: "H2C",
                table: "GlobalesFA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaqueteId",
                schema: "H2C",
                table: "GlobalesFA",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoCambioId",
                schema: "H2C",
                table: "GlobalesFA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoPartidaId",
                schema: "H2C",
                table: "GlobalesFA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesFA_BodegaDefaultId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "BodegaDefaultId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesFA_CategoriaClienteId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "CategoriaClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesFA_CondPagoContadoId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "CondPagoContadoId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesFA_CtrConsumoId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "CtrConsumoId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesFA_CtrCtaDocumentacionId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "CtrCtaDocumentacionId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesFA_CtrCtaFleteId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "CtrCtaFleteId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesFA_CtrCtaImpComisioId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "CtrCtaImpComisioId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesFA_CtrCtaImpuesto1Id",
                schema: "H2C",
                table: "GlobalesFA",
                column: "CtrCtaImpuesto1Id");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesFA_CtrCtaImpuesto2Id",
                schema: "H2C",
                table: "GlobalesFA",
                column: "CtrCtaImpuesto2Id");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesFA_CtrCtaSeguroId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "CtrCtaSeguroId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesFA_NivelPrecioId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "NivelPrecioId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesFA_NivelPrecioPublicoId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "NivelPrecioPublicoId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesFA_PaqueteId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "PaqueteId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesFA_TipoCambioId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "TipoCambioId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesFA_TipoPartidaId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "TipoPartidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesFA_Bodegas_BodegaDefaultId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "BodegaDefaultId",
                principalSchema: "H2C",
                principalTable: "Bodegas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesFA_CategoriasClientes_CategoriaClienteId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "CategoriaClienteId",
                principalSchema: "H2C",
                principalTable: "CategoriasClientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesFA_CentroCuenta_CtrCtaDocumentacionId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "CtrCtaDocumentacionId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesFA_CentroCuenta_CtrCtaFleteId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "CtrCtaFleteId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesFA_CentroCuenta_CtrCtaImpComisioId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "CtrCtaImpComisioId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesFA_CentroCuenta_CtrCtaImpuesto1Id",
                schema: "H2C",
                table: "GlobalesFA",
                column: "CtrCtaImpuesto1Id",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesFA_CentroCuenta_CtrCtaImpuesto2Id",
                schema: "H2C",
                table: "GlobalesFA",
                column: "CtrCtaImpuesto2Id",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesFA_CentroCuenta_CtrCtaSeguroId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "CtrCtaSeguroId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesFA_CentrosCosto_CtrConsumoId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "CtrConsumoId",
                principalSchema: "H2C",
                principalTable: "CentrosCosto",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesFA_CondicionesPago_CondPagoContadoId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "CondPagoContadoId",
                principalSchema: "H2C",
                principalTable: "CondicionesPago",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesFA_NivelesPrecios_NivelPrecioId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "NivelPrecioId",
                principalSchema: "H2C",
                principalTable: "NivelesPrecios",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesFA_NivelesPrecios_NivelPrecioPublicoId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "NivelPrecioPublicoId",
                principalSchema: "H2C",
                principalTable: "NivelesPrecios",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesFA_PaquetesContables_PaqueteId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "PaqueteId",
                principalSchema: "H2C",
                principalTable: "PaquetesContables",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesFA_TiposCambio_TipoCambioId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "TipoCambioId",
                principalSchema: "H2C",
                principalTable: "TiposCambio",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesFA_TiposPartida_TipoPartidaId",
                schema: "H2C",
                table: "GlobalesFA",
                column: "TipoPartidaId",
                principalSchema: "H2C",
                principalTable: "TiposPartida",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesFA_Bodegas_BodegaDefaultId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesFA_CategoriasClientes_CategoriaClienteId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesFA_CentroCuenta_CtrCtaDocumentacionId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesFA_CentroCuenta_CtrCtaFleteId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesFA_CentroCuenta_CtrCtaImpComisioId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesFA_CentroCuenta_CtrCtaImpuesto1Id",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesFA_CentroCuenta_CtrCtaImpuesto2Id",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesFA_CentroCuenta_CtrCtaSeguroId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesFA_CentrosCosto_CtrConsumoId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesFA_CondicionesPago_CondPagoContadoId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesFA_NivelesPrecios_NivelPrecioId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesFA_NivelesPrecios_NivelPrecioPublicoId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesFA_PaquetesContables_PaqueteId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesFA_TiposCambio_TipoCambioId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesFA_TiposPartida_TipoPartidaId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesFA_BodegaDefaultId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesFA_CategoriaClienteId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesFA_CondPagoContadoId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesFA_CtrConsumoId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesFA_CtrCtaDocumentacionId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesFA_CtrCtaFleteId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesFA_CtrCtaImpComisioId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesFA_CtrCtaImpuesto1Id",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesFA_CtrCtaImpuesto2Id",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesFA_CtrCtaSeguroId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesFA_NivelPrecioId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesFA_NivelPrecioPublicoId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesFA_PaqueteId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesFA_TipoCambioId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesFA_TipoPartidaId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "BodegaDefaultId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "CategoriaClienteId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "CondPagoContadoId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "CtrConsumoId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "CtrCtaDocumentacionId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "CtrCtaFleteId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "CtrCtaImpComisioId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "CtrCtaImpuesto1Id",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "CtrCtaImpuesto2Id",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "CtrCtaSeguroId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "NivelPrecioId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "NivelPrecioPublicoId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "PaqueteId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "TipoCambioId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.DropColumn(
                name: "TipoPartidaId",
                schema: "H2C",
                table: "GlobalesFA");

            migrationBuilder.AddColumn<string>(
                name: "BodegaDefault",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoriaCliente",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CondPagoContado",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaDocumentaci",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaFlete",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaImpComisio",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaImpuesto1",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaImpuesto2",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaSeguro",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrConsumo",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrDocumentanci",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrFlete",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrImpComisio",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrImpuesto1",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrImpuesto2",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrSeguro",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "Llave",
                schema: "H2C",
                table: "GlobalesFA",
                type: "smallint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MonedaNivel",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MonedaPublico",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NivPrePublico",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NivelPrecio",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Paquete",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoAsiento",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoCambio",
                schema: "H2C",
                table: "GlobalesFA",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);
        }
    }
}
