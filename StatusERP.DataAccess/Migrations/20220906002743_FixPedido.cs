using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixPedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bodega",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "ClaveReferenciaDE",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "ClienteCorporac",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "ClienteDireccion",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "ClienteOrigen",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "Cobrador",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "CodigoReferenciaDE",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "CondicionPago",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "FechaReferenciaDE",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "Moneda",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "NivelPrecio",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "NumConsRegExo",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "NumIRSEdeAgrGan",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "Pais",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "Ruta",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "SubtipoDocCXC",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "TipoDescuentoGlobal",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "TipoDocCXC",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "TipoFactura",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "TipoPago",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "TipoReferenciaDE",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "UADAMEnviarGLN",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "UADAMFechaRecepcion",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "UADAMFechaReclamo",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "UADAMNumeroProveedor",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "UADAMNumeroRecepcion",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "UADAMNumeroReclamo",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "UADCCFechaConsumo",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "UADCCHojaEntrada",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "UADCCRemision",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "UADGSEnviarGLN",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "UADGSFechaRecepcion",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "UADGSNumeroRecepcion",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "UADGSNumeroVendedor",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "UADPCEnviarGLN",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "UADPCNumeroVendedor",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "UADWMEnviarGLN",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "UADWMFechaReclamo",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "UADWMNumeroRecepcion",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "UADWMNumeroReclamo",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "UADWMNumeroVendedor",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "Vendedor",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "Zona",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.RenameColumn(
                name: "VersionNP",
                schema: "H2C",
                table: "PedidoEncs",
                newName: "ZonaId");

            migrationBuilder.AlterColumn<string>(
                name: "Usuario",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "UsrNoAprueba",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RazonDesaprueba",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RazonCancelaCoti",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BodegaId",
                schema: "H2C",
                table: "PedidoEncs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClienteCorporacId",
                schema: "H2C",
                table: "PedidoEncs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClienteDireccionId",
                schema: "H2C",
                table: "PedidoEncs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                schema: "H2C",
                table: "PedidoEncs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClienteOrigenId",
                schema: "H2C",
                table: "PedidoEncs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CobradorId",
                schema: "H2C",
                table: "PedidoEncs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CondicionPagoId",
                schema: "H2C",
                table: "PedidoEncs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaisId",
                schema: "H2C",
                table: "PedidoEncs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RutaId",
                schema: "H2C",
                table: "PedidoEncs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubTipoDocCCId",
                schema: "H2C",
                table: "PedidoEncs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VendedorId",
                schema: "H2C",
                table: "PedidoEncs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VersionNivelPrecioId",
                schema: "H2C",
                table: "PedidoEncs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PedidoEncs_BodegaId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "BodegaId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoEncs_ClienteCorporacId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "ClienteCorporacId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoEncs_ClienteDireccionId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "ClienteDireccionId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoEncs_ClienteId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoEncs_ClienteOrigenId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "ClienteOrigenId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoEncs_CobradorId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "CobradorId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoEncs_CondicionPagoId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "CondicionPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoEncs_PaisId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoEncs_RutaId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "RutaId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoEncs_SubTipoDocCCId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "SubTipoDocCCId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoEncs_VendedorId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "VendedorId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoEncs_VersionNivelPrecioId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "VersionNivelPrecioId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoEncs_ZonaId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "ZonaId");

            migrationBuilder.CreateIndex(
                name: "IxPedido",
                schema: "H2C",
                table: "PedidoEncs",
                column: "Pedido",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoEncs_Bodegas_BodegaId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "BodegaId",
                principalSchema: "H2C",
                principalTable: "Bodegas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoEncs_Clientes_ClienteCorporacId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "ClienteCorporacId",
                principalSchema: "H2C",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoEncs_Clientes_ClienteDireccionId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "ClienteDireccionId",
                principalSchema: "H2C",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoEncs_Clientes_ClienteId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "ClienteId",
                principalSchema: "H2C",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoEncs_Clientes_ClienteOrigenId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "ClienteOrigenId",
                principalSchema: "H2C",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoEncs_Cobradores_CobradorId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "CobradorId",
                principalSchema: "H2C",
                principalTable: "Cobradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoEncs_CondicionesPago_CondicionPagoId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "CondicionPagoId",
                principalSchema: "H2C",
                principalTable: "CondicionesPago",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoEncs_Paises_PaisId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "PaisId",
                principalSchema: "H2C",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoEncs_Rutas_RutaId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "RutaId",
                principalSchema: "H2C",
                principalTable: "Rutas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoEncs_SubTiposDocCC_SubTipoDocCCId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "SubTipoDocCCId",
                principalSchema: "H2C",
                principalTable: "SubTiposDocCC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoEncs_Vendedores_VendedorId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "VendedorId",
                principalSchema: "H2C",
                principalTable: "Vendedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoEncs_VersionesNivelPrecio_VersionNivelPrecioId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "VersionNivelPrecioId",
                principalSchema: "H2C",
                principalTable: "VersionesNivelPrecio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoEncs_Zonas_ZonaId",
                schema: "H2C",
                table: "PedidoEncs",
                column: "ZonaId",
                principalSchema: "H2C",
                principalTable: "Zonas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoEncs_Bodegas_BodegaId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoEncs_Clientes_ClienteCorporacId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoEncs_Clientes_ClienteDireccionId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoEncs_Clientes_ClienteId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoEncs_Clientes_ClienteOrigenId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoEncs_Cobradores_CobradorId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoEncs_CondicionesPago_CondicionPagoId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoEncs_Paises_PaisId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoEncs_Rutas_RutaId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoEncs_SubTiposDocCC_SubTipoDocCCId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoEncs_Vendedores_VendedorId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoEncs_VersionesNivelPrecio_VersionNivelPrecioId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoEncs_Zonas_ZonaId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropIndex(
                name: "IX_PedidoEncs_BodegaId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropIndex(
                name: "IX_PedidoEncs_ClienteCorporacId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropIndex(
                name: "IX_PedidoEncs_ClienteDireccionId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropIndex(
                name: "IX_PedidoEncs_ClienteId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropIndex(
                name: "IX_PedidoEncs_ClienteOrigenId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropIndex(
                name: "IX_PedidoEncs_CobradorId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropIndex(
                name: "IX_PedidoEncs_CondicionPagoId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropIndex(
                name: "IX_PedidoEncs_PaisId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropIndex(
                name: "IX_PedidoEncs_RutaId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropIndex(
                name: "IX_PedidoEncs_SubTipoDocCCId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropIndex(
                name: "IX_PedidoEncs_VendedorId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropIndex(
                name: "IX_PedidoEncs_VersionNivelPrecioId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropIndex(
                name: "IX_PedidoEncs_ZonaId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropIndex(
                name: "IxPedido",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "BodegaId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "ClienteCorporacId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "ClienteDireccionId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "ClienteOrigenId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "CobradorId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "CondicionPagoId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "PaisId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "RutaId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "SubTipoDocCCId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "VendedorId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.DropColumn(
                name: "VersionNivelPrecioId",
                schema: "H2C",
                table: "PedidoEncs");

            migrationBuilder.RenameColumn(
                name: "ZonaId",
                schema: "H2C",
                table: "PedidoEncs",
                newName: "VersionNP");

            migrationBuilder.AlterColumn<string>(
                name: "Usuario",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "UsrNoAprueba",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RazonDesaprueba",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RazonCancelaCoti",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bodega",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ClaveReferenciaDE",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClienteCorporac",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ClienteDireccion",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ClienteOrigen",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cobrador",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CodigoReferenciaDE",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CondicionPago",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaReferenciaDE",
                schema: "H2C",
                table: "PedidoEncs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Moneda",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NivelPrecio",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NumConsRegExo",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumIRSEdeAgrGan",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ruta",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<short>(
                name: "SubtipoDocCXC",
                schema: "H2C",
                table: "PedidoEncs",
                type: "smallint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoDescuentoGlobal",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoDocCXC",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoFactura",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoPago",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoReferenciaDE",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADAMEnviarGLN",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADAMFechaRecepcion",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADAMFechaReclamo",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADAMNumeroProveedor",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADAMNumeroRecepcion",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADAMNumeroReclamo",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UADCCFechaConsumo",
                schema: "H2C",
                table: "PedidoEncs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADCCHojaEntrada",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADCCRemision",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADGSEnviarGLN",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADGSFechaRecepcion",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADGSNumeroRecepcion",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADGSNumeroVendedor",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADPCEnviarGLN",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADPCNumeroVendedor",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADWMEnviarGLN",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADWMFechaReclamo",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADWMNumeroRecepcion",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADWMNumeroReclamo",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADWMNumeroVendedor",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendedor",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Zona",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");
        }
    }
}
