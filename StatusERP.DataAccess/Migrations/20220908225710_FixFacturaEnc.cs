using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixFacturaEnc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FacturaEncs_DivGeograficas1_DivGeografica1Id",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_FacturaEncs_DivGeograficas2_DivGeografica2Id",
                schema: "H2C",
                table: "FacturaEncs");

            //migrationBuilder.DropColumn(
            //    name: "TipoDesc",
            //    schema: "H2C",
            //    table: "PedidoDets");

            migrationBuilder.DropColumn(
                name: "ActDetrac",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "ActividadComercial",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "AsientoDocumento",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "ClaveDE",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "ClaveReferenciaDE",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "ClienteCorporac",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "ClienteDireccion",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "ClienteOrigen",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "CodigoReferenciaDE",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "CondicionPago",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "Consecutivo",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "CuentaAsiento",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "DireccionEmbarque",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "DocCreditoCXC",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "EstaDespachado",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "FacturaOriginalReemplazo",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "FechaReferenciaDE",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "GUUIDOriginal",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "Moneda",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "NivelPrecio",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "NumConsRegExo",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "NumIRSedeAgrGan",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "PorcDetrac",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "SubTipoDocCXC",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "TasaGanOcasionalPorc",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "TipoCreditoCXC",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "TipoDescuentoGlobal",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "TipoDetrac",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "TipoDocCXC",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "TipoFactura",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "TipoNC",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "TipoOperacion",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "TipoPago",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "TipoReferenciaDE",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "UADAMEnviarGLN",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "UADAMFechaRecepcion",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "UADAMFechaReclamo",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "UADAMNumeroProveedor",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "UADAMNumeroRecepcion",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "UADAMNumeroReclamo",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "UADCCFechaConsumo",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "UADCCHojaEntrada",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "UADCCRemision",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "UADGSEnviarGLN",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "UADGSFechaRecepcion",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "UADGSNumeroRecepcion",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "UADGSNumeroVendedor",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "UADPCEnviarGLN",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "UADPCNumeroVendedor",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "UADWMEnviarGLN",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "UADWMFechaReclamo",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "UADWMNumeroRecepcion",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "UADWMNumeroVendedor",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "UADWMTipoNC",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "UsoCFDI",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.RenameColumn(
                name: "VersionNP",
                schema: "H2C",
                table: "FacturaEncs",
                newName: "VersionNPId");

            migrationBuilder.RenameColumn(
                name: "UADWMNumeroReclamo",
                schema: "H2C",
                table: "FacturaEncs",
                newName: "PartidaDocumento");

            migrationBuilder.RenameColumn(
                name: "DivGeografica2Id",
                schema: "H2C",
                table: "FacturaEncs",
                newName: "SubTipoDocCCId");

            migrationBuilder.RenameColumn(
                name: "DivGeografica1Id",
                schema: "H2C",
                table: "FacturaEncs",
                newName: "DireccEmbarqueId");

            migrationBuilder.RenameIndex(
                name: "IX_FacturaEncs_DivGeografica2Id",
                schema: "H2C",
                table: "FacturaEncs",
                newName: "IX_FacturaEncs_SubTipoDocCCId");

            migrationBuilder.RenameIndex(
                name: "IX_FacturaEncs_DivGeografica1Id",
                schema: "H2C",
                table: "FacturaEncs",
                newName: "IX_FacturaEncs_DireccEmbarqueId");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioAnula",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Usuario",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<int>(
                name: "MovInventarioEncId",
                schema: "H2C",
                table: "FacturaEncs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteCorporacId",
                schema: "H2C",
                table: "FacturaEncs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClienteDireccionId",
                schema: "H2C",
                table: "FacturaEncs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClienteOrigenId",
                schema: "H2C",
                table: "FacturaEncs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CondicionPagoId",
                schema: "H2C",
                table: "FacturaEncs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConsecutivoId",
                schema: "H2C",
                table: "FacturaEncs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DocCreditoCCId",
                schema: "H2C",
                table: "FacturaEncs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FacOriginalReemplazoId",
                schema: "H2C",
                table: "FacturaEncs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FacturaEncs_ClienteCorporacId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "ClienteCorporacId");

            migrationBuilder.CreateIndex(
                name: "IX_FacturaEncs_ClienteDireccionId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "ClienteDireccionId");

            migrationBuilder.CreateIndex(
                name: "IX_FacturaEncs_ClienteOrigenId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "ClienteOrigenId");

            migrationBuilder.CreateIndex(
                name: "IX_FacturaEncs_CondicionPagoId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "CondicionPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_FacturaEncs_ConsecutivoId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "ConsecutivoId");

            migrationBuilder.CreateIndex(
                name: "IX_FacturaEncs_DivisionGeografica1Id",
                schema: "H2C",
                table: "FacturaEncs",
                column: "DivisionGeografica1Id");

            migrationBuilder.CreateIndex(
                name: "IX_FacturaEncs_DivisionGeografica2Id",
                schema: "H2C",
                table: "FacturaEncs",
                column: "DivisionGeografica2Id");

            migrationBuilder.CreateIndex(
                name: "IX_FacturaEncs_DocCreditoCCId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "DocCreditoCCId");

            migrationBuilder.CreateIndex(
                name: "IX_FacturaEncs_FacOriginalReemplazoId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "FacOriginalReemplazoId");

            migrationBuilder.CreateIndex(
                name: "IX_FacturaEncs_MovInventarioEncId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "MovInventarioEncId");

            migrationBuilder.CreateIndex(
                name: "IX_FacturaEncs_VersionNPId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "VersionNPId");

            migrationBuilder.CreateIndex(
                name: "IxTipoDoc_Factura",
                schema: "H2C",
                table: "FacturaEncs",
                columns: new[] { "TipoDocumento", "Factura" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaEncs_Clientes_ClienteCorporacId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "ClienteCorporacId",
                principalSchema: "H2C",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaEncs_Clientes_ClienteDireccionId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "ClienteDireccionId",
                principalSchema: "H2C",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaEncs_Clientes_ClienteOrigenId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "ClienteOrigenId",
                principalSchema: "H2C",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaEncs_CondicionesPago_CondicionPagoId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "CondicionPagoId",
                principalSchema: "H2C",
                principalTable: "CondicionesPago",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaEncs_ConsecutivosFA_ConsecutivoId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "ConsecutivoId",
                principalSchema: "H2C",
                principalTable: "ConsecutivosFA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaEncs_DireccEmbarques_DireccEmbarqueId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "DireccEmbarqueId",
                principalSchema: "H2C",
                principalTable: "DireccEmbarques",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaEncs_DivGeograficas1_DivisionGeografica1Id",
                schema: "H2C",
                table: "FacturaEncs",
                column: "DivisionGeografica1Id",
                principalSchema: "H2C",
                principalTable: "DivGeograficas1",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaEncs_DivGeograficas2_DivisionGeografica2Id",
                schema: "H2C",
                table: "FacturaEncs",
                column: "DivisionGeografica2Id",
                principalSchema: "H2C",
                principalTable: "DivGeograficas2",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaEncs_DocumentosCC_DocCreditoCCId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "DocCreditoCCId",
                principalSchema: "H2C",
                principalTable: "DocumentosCC",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaEncs_FacturaEncs_FacOriginalReemplazoId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "FacOriginalReemplazoId",
                principalSchema: "H2C",
                principalTable: "FacturaEncs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaEncs_MovsInventarioEnc_MovInventarioEncId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "MovInventarioEncId",
                principalSchema: "H2C",
                principalTable: "MovsInventarioEnc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaEncs_SubTiposDocCC_SubTipoDocCCId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "SubTipoDocCCId",
                principalSchema: "H2C",
                principalTable: "SubTiposDocCC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaEncs_VersionesNivelPrecio_VersionNPId",
                schema: "H2C",
                table: "FacturaEncs",
                column: "VersionNPId",
                principalSchema: "H2C",
                principalTable: "VersionesNivelPrecio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FacturaEncs_Clientes_ClienteCorporacId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_FacturaEncs_Clientes_ClienteDireccionId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_FacturaEncs_Clientes_ClienteOrigenId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_FacturaEncs_CondicionesPago_CondicionPagoId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_FacturaEncs_ConsecutivosFA_ConsecutivoId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_FacturaEncs_DireccEmbarques_DireccEmbarqueId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_FacturaEncs_DivGeograficas1_DivisionGeografica1Id",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_FacturaEncs_DivGeograficas2_DivisionGeografica2Id",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_FacturaEncs_DocumentosCC_DocCreditoCCId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_FacturaEncs_FacturaEncs_FacOriginalReemplazoId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_FacturaEncs_MovsInventarioEnc_MovInventarioEncId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_FacturaEncs_SubTiposDocCC_SubTipoDocCCId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropForeignKey(
                name: "FK_FacturaEncs_VersionesNivelPrecio_VersionNPId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropIndex(
                name: "IX_FacturaEncs_ClienteCorporacId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropIndex(
                name: "IX_FacturaEncs_ClienteDireccionId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropIndex(
                name: "IX_FacturaEncs_ClienteOrigenId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropIndex(
                name: "IX_FacturaEncs_CondicionPagoId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropIndex(
                name: "IX_FacturaEncs_ConsecutivoId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropIndex(
                name: "IX_FacturaEncs_DivisionGeografica1Id",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropIndex(
                name: "IX_FacturaEncs_DivisionGeografica2Id",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropIndex(
                name: "IX_FacturaEncs_DocCreditoCCId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropIndex(
                name: "IX_FacturaEncs_FacOriginalReemplazoId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropIndex(
                name: "IX_FacturaEncs_MovInventarioEncId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropIndex(
                name: "IX_FacturaEncs_VersionNPId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropIndex(
                name: "IxTipoDoc_Factura",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "ClienteCorporacId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "ClienteDireccionId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "ClienteOrigenId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "CondicionPagoId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "ConsecutivoId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "DocCreditoCCId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.DropColumn(
                name: "FacOriginalReemplazoId",
                schema: "H2C",
                table: "FacturaEncs");

            migrationBuilder.RenameColumn(
                name: "VersionNPId",
                schema: "H2C",
                table: "FacturaEncs",
                newName: "VersionNP");

            migrationBuilder.RenameColumn(
                name: "SubTipoDocCCId",
                schema: "H2C",
                table: "FacturaEncs",
                newName: "DivGeografica2Id");

            migrationBuilder.RenameColumn(
                name: "PartidaDocumento",
                schema: "H2C",
                table: "FacturaEncs",
                newName: "UADWMNumeroReclamo");

            migrationBuilder.RenameColumn(
                name: "DireccEmbarqueId",
                schema: "H2C",
                table: "FacturaEncs",
                newName: "DivGeografica1Id");

            migrationBuilder.RenameIndex(
                name: "IX_FacturaEncs_SubTipoDocCCId",
                schema: "H2C",
                table: "FacturaEncs",
                newName: "IX_FacturaEncs_DivGeografica2Id");

            migrationBuilder.RenameIndex(
                name: "IX_FacturaEncs_DireccEmbarqueId",
                schema: "H2C",
                table: "FacturaEncs",
                newName: "IX_FacturaEncs_DivGeografica1Id");

            //migrationBuilder.AddColumn<string>(
            //    name: "TipoDesc",
            //    schema: "H2C",
            //    table: "PedidoDets",
            //    type: "nvarchar(10)",
            //    maxLength: 10,
            //    nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioAnula",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Usuario",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<int>(
                name: "MovInventarioEncId",
                schema: "H2C",
                table: "FacturaEncs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ActDetrac",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ActividadComercial",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AsientoDocumento",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClaveDE",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClaveReferenciaDE",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClienteCorporac",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ClienteDireccion",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ClienteOrigen",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CodigoReferenciaDE",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CondicionPago",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Consecutivo",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CuentaAsiento",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DireccionEmbarque",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocCreditoCXC",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EstaDespachado",
                schema: "H2C",
                table: "FacturaEncs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FacturaOriginalReemplazo",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaReferenciaDE",
                schema: "H2C",
                table: "FacturaEncs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUUIDOriginal",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Moneda",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NivelPrecio",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NumConsRegExo",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumIRSedeAgrGan",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PorcDetrac",
                schema: "H2C",
                table: "FacturaEncs",
                type: "decimal(28,8)",
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "SubTipoDocCXC",
                schema: "H2C",
                table: "FacturaEncs",
                type: "smallint",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TasaGanOcasionalPorc",
                schema: "H2C",
                table: "FacturaEncs",
                type: "decimal(28,8)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoCreditoCXC",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoDescuentoGlobal",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoDetrac",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoDocCXC",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoFactura",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoNC",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoOperacion",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoPago",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoReferenciaDE",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADAMEnviarGLN",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADAMFechaRecepcion",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADAMFechaReclamo",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADAMNumeroProveedor",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADAMNumeroRecepcion",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADAMNumeroReclamo",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UADCCFechaConsumo",
                schema: "H2C",
                table: "FacturaEncs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADCCHojaEntrada",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADCCRemision",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADGSEnviarGLN",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADGSFechaRecepcion",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADGSNumeroRecepcion",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADGSNumeroVendedor",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADPCEnviarGLN",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADPCNumeroVendedor",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADWMEnviarGLN",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADWMFechaReclamo",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADWMNumeroRecepcion",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADWMNumeroVendedor",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UADWMTipoNC",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsoCFDI",
                schema: "H2C",
                table: "FacturaEncs",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaEncs_DivGeograficas1_DivGeografica1Id",
                schema: "H2C",
                table: "FacturaEncs",
                column: "DivGeografica1Id",
                principalSchema: "H2C",
                principalTable: "DivGeograficas1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaEncs_DivGeograficas2_DivGeografica2Id",
                schema: "H2C",
                table: "FacturaEncs",
                column: "DivGeografica2Id",
                principalSchema: "H2C",
                principalTable: "DivGeograficas2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
