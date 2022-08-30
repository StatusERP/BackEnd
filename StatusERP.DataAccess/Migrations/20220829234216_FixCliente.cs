using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "APIRecepcionDE",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "AfectacionIVA",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CURP",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CategoriaCliente",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Cobrador",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CodigoImpuesto",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CondicionPago",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "DivisionGeografica3",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "DivisionGeografica4",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ItemHacienda",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "MetodoPago",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ModeloRetencion",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Moneda",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "MonedaNivel",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "NivelPrecio",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Pais",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "PassAPIRecepecion",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "PermiteDocGP",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "RegimenTrib",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Ruta",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "TipificacionCliente",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "TipoImpuesto",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "TipoTarjeta",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "UserAPIRecepcion",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "UsoCFDI",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Vendedor",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Zona",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "XsltPersonalizado",
                schema: "H2C",
                table: "Clientes",
                newName: "XSLTPersonalizado");

            migrationBuilder.RenameColumn(
                name: "UsaAPIRecepcion",
                schema: "H2C",
                table: "Clientes",
                newName: "EsBuenContribuyente");

            migrationBuilder.RenameColumn(
                name: "DiasPromAtraso",
                schema: "H2C",
                table: "Clientes",
                newName: "DiasPromedAtraso");

            migrationBuilder.RenameColumn(
                name: "ContribuyenteId",
                schema: "H2C",
                table: "Clientes",
                newName: "ZonaId");

            migrationBuilder.RenameColumn(
                name: "CliCorporacAsoc",
                schema: "H2C",
                table: "Clientes",
                newName: "XSLTPersonalizadoCredito");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioUltMod",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioCreacion",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaClienteId",
                schema: "H2C",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CliCorporacAsocId",
                schema: "H2C",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CobradorId",
                schema: "H2C",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CondicionPagoId",
                schema: "H2C",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DetalleDireccionId",
                schema: "H2C",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImpuestoId",
                schema: "H2C",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MetodoPagoId",
                schema: "H2C",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MonedaId",
                schema: "H2C",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NivelPrecioId",
                schema: "H2C",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaisId",
                schema: "H2C",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RutaId",
                schema: "H2C",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoImpuestoId",
                schema: "H2C",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoTarjetaId",
                schema: "H2C",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VendedorId",
                schema: "H2C",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CategoriaClienteId",
                schema: "H2C",
                table: "Clientes",
                column: "CategoriaClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CliCorporacAsocId",
                schema: "H2C",
                table: "Clientes",
                column: "CliCorporacAsocId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CobradorId",
                schema: "H2C",
                table: "Clientes",
                column: "CobradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CondicionPagoId",
                schema: "H2C",
                table: "Clientes",
                column: "CondicionPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_DetalleDireccionId",
                schema: "H2C",
                table: "Clientes",
                column: "DetalleDireccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ImpuestoId",
                schema: "H2C",
                table: "Clientes",
                column: "ImpuestoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_MetodoPagoId",
                schema: "H2C",
                table: "Clientes",
                column: "MetodoPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_MonedaId",
                schema: "H2C",
                table: "Clientes",
                column: "MonedaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_NivelPrecioId",
                schema: "H2C",
                table: "Clientes",
                column: "NivelPrecioId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_PaisId",
                schema: "H2C",
                table: "Clientes",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_RutaId",
                schema: "H2C",
                table: "Clientes",
                column: "RutaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_TipoImpuestoId",
                schema: "H2C",
                table: "Clientes",
                column: "TipoImpuestoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_TipoTarjetaId",
                schema: "H2C",
                table: "Clientes",
                column: "TipoTarjetaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_VendedorId",
                schema: "H2C",
                table: "Clientes",
                column: "VendedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ZonaId",
                schema: "H2C",
                table: "Clientes",
                column: "ZonaId");

            migrationBuilder.CreateIndex(
                name: "IxCodCliente",
                schema: "H2C",
                table: "Clientes",
                column: "CodCliente",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_CategoriasClientes_CategoriaClienteId",
                schema: "H2C",
                table: "Clientes",
                column: "CategoriaClienteId",
                principalSchema: "H2C",
                principalTable: "CategoriasClientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Clientes_CliCorporacAsocId",
                schema: "H2C",
                table: "Clientes",
                column: "CliCorporacAsocId",
                principalSchema: "H2C",
                principalTable: "Clientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Cobradores_CobradorId",
                schema: "H2C",
                table: "Clientes",
                column: "CobradorId",
                principalSchema: "H2C",
                principalTable: "Cobradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_CondicionesPago_CondicionPagoId",
                schema: "H2C",
                table: "Clientes",
                column: "CondicionPagoId",
                principalSchema: "H2C",
                principalTable: "CondicionesPago",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_DetalleDirecciones_DetalleDireccionId",
                schema: "H2C",
                table: "Clientes",
                column: "DetalleDireccionId",
                principalSchema: "H2C",
                principalTable: "DetalleDirecciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Impuestos_ImpuestoId",
                schema: "H2C",
                table: "Clientes",
                column: "ImpuestoId",
                principalSchema: "H2C",
                principalTable: "Impuestos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_MetodosPago_MetodoPagoId",
                schema: "H2C",
                table: "Clientes",
                column: "MetodoPagoId",
                principalSchema: "H2C",
                principalTable: "MetodosPago",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Monedas_MonedaId",
                schema: "H2C",
                table: "Clientes",
                column: "MonedaId",
                principalSchema: "H2C",
                principalTable: "Monedas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_NivelesPrecios_NivelPrecioId",
                schema: "H2C",
                table: "Clientes",
                column: "NivelPrecioId",
                principalSchema: "H2C",
                principalTable: "NivelesPrecios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Paises_PaisId",
                schema: "H2C",
                table: "Clientes",
                column: "PaisId",
                principalSchema: "H2C",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Rutas_RutaId",
                schema: "H2C",
                table: "Clientes",
                column: "RutaId",
                principalSchema: "H2C",
                principalTable: "Rutas",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_TiposImpuesto_TipoImpuestoId",
                schema: "H2C",
                table: "Clientes",
                column: "TipoImpuestoId",
                principalSchema: "H2C",
                principalTable: "TiposImpuesto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_TiposTarjeta_TipoTarjetaId",
                schema: "H2C",
                table: "Clientes",
                column: "TipoTarjetaId",
                principalSchema: "H2C",
                principalTable: "TiposTarjeta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Vendedores_VendedorId",
                schema: "H2C",
                table: "Clientes",
                column: "VendedorId",
                principalSchema: "H2C",
                principalTable: "Vendedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Zonas_ZonaId",
                schema: "H2C",
                table: "Clientes",
                column: "ZonaId",
                principalSchema: "H2C",
                principalTable: "Zonas",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_CategoriasClientes_CategoriaClienteId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Clientes_CliCorporacAsocId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Cobradores_CobradorId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_CondicionesPago_CondicionPagoId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_DetalleDirecciones_DetalleDireccionId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Impuestos_ImpuestoId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_MetodosPago_MetodoPagoId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Monedas_MonedaId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_NivelesPrecios_NivelPrecioId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Paises_PaisId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Rutas_RutaId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_TiposImpuesto_TipoImpuestoId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_TiposTarjeta_TipoTarjetaId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Vendedores_VendedorId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Zonas_ZonaId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_CategoriaClienteId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_CliCorporacAsocId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_CobradorId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_CondicionPagoId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_DetalleDireccionId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_ImpuestoId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_MetodoPagoId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_MonedaId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_NivelPrecioId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_PaisId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_RutaId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_TipoImpuestoId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_TipoTarjetaId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_VendedorId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_ZonaId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IxCodCliente",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CategoriaClienteId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CliCorporacAsocId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CobradorId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CondicionPagoId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "DetalleDireccionId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ImpuestoId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "MetodoPagoId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "MonedaId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "NivelPrecioId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "PaisId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "RutaId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "TipoImpuestoId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "TipoTarjetaId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "VendedorId",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "XSLTPersonalizado",
                schema: "H2C",
                table: "Clientes",
                newName: "XsltPersonalizado");

            migrationBuilder.RenameColumn(
                name: "ZonaId",
                schema: "H2C",
                table: "Clientes",
                newName: "ContribuyenteId");

            migrationBuilder.RenameColumn(
                name: "XSLTPersonalizadoCredito",
                schema: "H2C",
                table: "Clientes",
                newName: "CliCorporacAsoc");

            migrationBuilder.RenameColumn(
                name: "EsBuenContribuyente",
                schema: "H2C",
                table: "Clientes",
                newName: "UsaAPIRecepcion");

            migrationBuilder.RenameColumn(
                name: "DiasPromedAtraso",
                schema: "H2C",
                table: "Clientes",
                newName: "DiasPromAtraso");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioUltMod",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioCreacion",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "APIRecepcionDE",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AfectacionIVA",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CURP",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoriaCliente",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cobrador",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CodigoImpuesto",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CondicionPago",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DivisionGeografica3",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DivisionGeografica4",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemHacienda",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetodoPago",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModeloRetencion",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Moneda",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MonedaNivel",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NivelPrecio",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PassAPIRecepecion",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PermiteDocGP",
                schema: "H2C",
                table: "Clientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RegimenTrib",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ruta",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TipificacionCliente",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoImpuesto",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoTarjeta",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserAPIRecepcion",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsoCFDI",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendedor",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Zona",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");
        }
    }
}
