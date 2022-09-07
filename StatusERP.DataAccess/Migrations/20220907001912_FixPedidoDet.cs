using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixPedidoDet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Articulo",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropColumn(
                name: "Bodega",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropColumn(
                name: "CentroCosto",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropColumn(
                name: "CuentaContable",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropColumn(
                name: "Localizacion",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropColumn(
                name: "Lote",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropColumn(
                name: "Pedido",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropColumn(
                name: "TipoDescuentoLinea",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropColumn(
                name: "UnidadDistribucio",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.AddColumn<int>(
                name: "ArticuloId",
                schema: "H2C",
                table: "PedidoDets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BodegaId",
                schema: "H2C",
                table: "PedidoDets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CentroCuentaId",
                schema: "H2C",
                table: "PedidoDets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocalizacionId",
                schema: "H2C",
                table: "PedidoDets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LoteId",
                schema: "H2C",
                table: "PedidoDets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PedidoEncId",
                schema: "H2C",
                table: "PedidoDets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnidadDistribucionId",
                schema: "H2C",
                table: "PedidoDets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PedidoDets_ArticuloId",
                schema: "H2C",
                table: "PedidoDets",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoDets_BodegaId",
                schema: "H2C",
                table: "PedidoDets",
                column: "BodegaId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoDets_CentroCuentaId",
                schema: "H2C",
                table: "PedidoDets",
                column: "CentroCuentaId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoDets_LocalizacionId",
                schema: "H2C",
                table: "PedidoDets",
                column: "LocalizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoDets_LoteId",
                schema: "H2C",
                table: "PedidoDets",
                column: "LoteId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoDets_UnidadDistribucionId",
                schema: "H2C",
                table: "PedidoDets",
                column: "UnidadDistribucionId");

            migrationBuilder.CreateIndex(
                name: "IxPedidoEnc_PedidoLinea",
                schema: "H2C",
                table: "PedidoDets",
                columns: new[] { "PedidoEncId", "PedidoLinea" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoDets_Articulos_ArticuloId",
                schema: "H2C",
                table: "PedidoDets",
                column: "ArticuloId",
                principalSchema: "H2C",
                principalTable: "Articulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoDets_Bodegas_BodegaId",
                schema: "H2C",
                table: "PedidoDets",
                column: "BodegaId",
                principalSchema: "H2C",
                principalTable: "Bodegas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoDets_CentroCuenta_CentroCuentaId",
                schema: "H2C",
                table: "PedidoDets",
                column: "CentroCuentaId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoDets_Localizaciones_LocalizacionId",
                schema: "H2C",
                table: "PedidoDets",
                column: "LocalizacionId",
                principalSchema: "H2C",
                principalTable: "Localizaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoDets_Lotes_LoteId",
                schema: "H2C",
                table: "PedidoDets",
                column: "LoteId",
                principalSchema: "H2C",
                principalTable: "Lotes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoDets_PedidoEncs_PedidoEncId",
                schema: "H2C",
                table: "PedidoDets",
                column: "PedidoEncId",
                principalSchema: "H2C",
                principalTable: "PedidoEncs",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoDets_UnidadesMedida_UnidadDistribucionId",
                schema: "H2C",
                table: "PedidoDets",
                column: "UnidadDistribucionId",
                principalSchema: "H2C",
                principalTable: "UnidadesMedida",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoDets_Articulos_ArticuloId",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoDets_Bodegas_BodegaId",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoDets_CentroCuenta_CentroCuentaId",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoDets_Localizaciones_LocalizacionId",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoDets_Lotes_LoteId",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoDets_PedidoEncs_PedidoEncId",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoDets_UnidadesMedida_UnidadDistribucionId",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropIndex(
                name: "IX_PedidoDets_ArticuloId",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropIndex(
                name: "IX_PedidoDets_BodegaId",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropIndex(
                name: "IX_PedidoDets_CentroCuentaId",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropIndex(
                name: "IX_PedidoDets_LocalizacionId",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropIndex(
                name: "IX_PedidoDets_LoteId",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropIndex(
                name: "IX_PedidoDets_UnidadDistribucionId",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropIndex(
                name: "IxPedidoEnc_PedidoLinea",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropColumn(
                name: "ArticuloId",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropColumn(
                name: "BodegaId",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropColumn(
                name: "CentroCuentaId",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropColumn(
                name: "LocalizacionId",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropColumn(
                name: "LoteId",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropColumn(
                name: "PedidoEncId",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.DropColumn(
                name: "UnidadDistribucionId",
                schema: "H2C",
                table: "PedidoDets");

            migrationBuilder.AddColumn<string>(
                name: "Articulo",
                schema: "H2C",
                table: "PedidoDets",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Bodega",
                schema: "H2C",
                table: "PedidoDets",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CentroCosto",
                schema: "H2C",
                table: "PedidoDets",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CuentaContable",
                schema: "H2C",
                table: "PedidoDets",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Localizacion",
                schema: "H2C",
                table: "PedidoDets",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lote",
                schema: "H2C",
                table: "PedidoDets",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pedido",
                schema: "H2C",
                table: "PedidoDets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TipoDescuentoLinea",
                schema: "H2C",
                table: "PedidoDets",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UnidadDistribucio",
                schema: "H2C",
                table: "PedidoDets",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true);
        }
    }
}
