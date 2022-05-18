using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class TablasCI_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AjusteConfig",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropColumn(
                name: "Articulo",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropColumn(
                name: "Bodega",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropColumn(
                name: "CentroCosto",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropColumn(
                name: "CuentaContable",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropColumn(
                name: "DocTributario",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropColumn(
                name: "Localizacion",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropColumn(
                name: "Lote",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.RenameColumn(
                name: "Lote",
                schema: "H2C",
                table: "ExistenciaLotes",
                newName: "LoteId");

            migrationBuilder.RenameColumn(
                name: "Localización",
                schema: "H2C",
                table: "ExistenciaLotes",
                newName: "LocalizacionId");

            migrationBuilder.RenameColumn(
                name: "Bodega",
                schema: "H2C",
                table: "ExistenciaLotes",
                newName: "BodegaId");

            migrationBuilder.RenameColumn(
                name: "Articulo",
                schema: "H2C",
                table: "ExistenciaLotes",
                newName: "ArticuloId");

            migrationBuilder.RenameColumn(
                name: "SubsubtipoId",
                schema: "H2C",
                table: "AjustesSubSubTipo",
                newName: "Subsubtipo");

            migrationBuilder.AlterColumn<int>(
                name: "UnidadDistribucion",
                schema: "H2C",
                table: "MovsInventarioDet",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AjusteConfigId",
                schema: "H2C",
                table: "MovsInventarioDet",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArticuloId",
                schema: "H2C",
                table: "MovsInventarioDet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BodegaId",
                schema: "H2C",
                table: "MovsInventarioDet",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CentroCuentaId",
                schema: "H2C",
                table: "MovsInventarioDet",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DocTributarioId",
                schema: "H2C",
                table: "MovsInventarioDet",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocalizacionId",
                schema: "H2C",
                table: "MovsInventarioDet",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LoteId",
                schema: "H2C",
                table: "MovsInventarioDet",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "unidadMedidaId",
                schema: "H2C",
                table: "MovsInventarioDet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TiposOperacion",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodTipoOperacion = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposOperacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposPago",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodTipoPago = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposPago", x => x.Id);
                });

            //migrationBuilder.CreateIndex(
            //    name: "IxUsuarioAjuste",
            //    schema: "H2C",
            //    table: "UsuarioAjusteInv",
            //    columns: new[] { "Usuario", "AjusteConfig" },
            //    unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MovsInventarioDet_AjusteConfigId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "AjusteConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_MovsInventarioDet_ArticuloId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IX_MovsInventarioDet_BodegaId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "BodegaId");

            migrationBuilder.CreateIndex(
                name: "IX_MovsInventarioDet_CentroCuentaId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "CentroCuentaId");

            migrationBuilder.CreateIndex(
                name: "IX_MovsInventarioDet_DocTributarioId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "DocTributarioId");

            migrationBuilder.CreateIndex(
                name: "IX_MovsInventarioDet_LocalizacionId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "LocalizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_MovsInventarioDet_LoteId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "LoteId");

            migrationBuilder.CreateIndex(
                name: "IX_MovsInventarioDet_unidadMedidaId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "unidadMedidaId");

            migrationBuilder.CreateIndex(
                name: "IxArtLoteSecLote",
                schema: "H2C",
                table: "IngresosLotes",
                columns: new[] { "Articulo", "Lote", "SecuenciaLote" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExistenciaLotes_ArticuloId",
                schema: "H2C",
                table: "ExistenciaLotes",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IX_ExistenciaLotes_BodegaId",
                schema: "H2C",
                table: "ExistenciaLotes",
                column: "BodegaId");

            migrationBuilder.CreateIndex(
                name: "IX_ExistenciaLotes_LocalizacionId",
                schema: "H2C",
                table: "ExistenciaLotes",
                column: "LocalizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExistenciaLotes_LoteId",
                schema: "H2C",
                table: "ExistenciaLotes",
                column: "LoteId");

            migrationBuilder.CreateIndex(
                name: "IxConsecutivoInvUsuario",
                schema: "H2C",
                table: "ConsecutivosInvUsuarios",
                columns: new[] { "Consecutivo", "Usuario" });

            migrationBuilder.CreateIndex(
                name: "IxCodConsecutivo",
                schema: "H2C",
                table: "ConsecutivosInv",
                column: "CodConsecutivo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IxAjusteSubtipo",
                schema: "H2C",
                table: "AjustesSubTipo",
                columns: new[] { "AjusteConfig", "SubTipo" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IxAjusteSubsubtipo",
                schema: "H2C",
                table: "AjustesSubSubTipo",
                columns: new[] { "AjusteConfig", "Subsubtipo" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IxCodAjusteConfig",
                schema: "H2C",
                table: "AjustesConfig",
                column: "CodAjusteConfig",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IxCodTipoOperacion",
                schema: "H2C",
                table: "TiposOperacion",
                column: "CodTipoOperacion");

            migrationBuilder.CreateIndex(
                name: "IxCodTipoPago",
                schema: "H2C",
                table: "TiposPago",
                column: "CodTipoPago");

            migrationBuilder.AddForeignKey(
                name: "FK_ExistenciaLotes_Articulos_ArticuloId",
                schema: "H2C",
                table: "ExistenciaLotes",
                column: "ArticuloId",
                principalSchema: "H2C",
                principalTable: "Articulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExistenciaLotes_Bodegas_BodegaId",
                schema: "H2C",
                table: "ExistenciaLotes",
                column: "BodegaId",
                principalSchema: "H2C",
                principalTable: "Bodegas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExistenciaLotes_Localizaciones_LocalizacionId",
                schema: "H2C",
                table: "ExistenciaLotes",
                column: "LocalizacionId",
                principalSchema: "H2C",
                principalTable: "Localizaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ExistenciaLotes_Lotes_LoteId",
                schema: "H2C",
                table: "ExistenciaLotes",
                column: "LoteId",
                principalSchema: "H2C",
                principalTable: "Lotes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovsInventarioDet_AjustesConfig_AjusteConfigId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "AjusteConfigId",
                principalSchema: "H2C",
                principalTable: "AjustesConfig",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovsInventarioDet_Articulos_ArticuloId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "ArticuloId",
                principalSchema: "H2C",
                principalTable: "Articulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovsInventarioDet_Bodegas_BodegaId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "BodegaId",
                principalSchema: "H2C",
                principalTable: "Bodegas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovsInventarioDet_CentroCuenta_CentroCuentaId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "CentroCuentaId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovsInventarioDet_DocTributarios_DocTributarioId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "DocTributarioId",
                principalSchema: "H2C",
                principalTable: "DocTributarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovsInventarioDet_Localizaciones_LocalizacionId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "LocalizacionId",
                principalSchema: "H2C",
                principalTable: "Localizaciones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovsInventarioDet_Lotes_LoteId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "LoteId",
                principalSchema: "H2C",
                principalTable: "Lotes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovsInventarioDet_UnidadesMedida_unidadMedidaId",
                schema: "H2C",
                table: "MovsInventarioDet",
                column: "unidadMedidaId",
                principalSchema: "H2C",
                principalTable: "UnidadesMedida",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExistenciaLotes_Articulos_ArticuloId",
                schema: "H2C",
                table: "ExistenciaLotes");

            migrationBuilder.DropForeignKey(
                name: "FK_ExistenciaLotes_Bodegas_BodegaId",
                schema: "H2C",
                table: "ExistenciaLotes");

            migrationBuilder.DropForeignKey(
                name: "FK_ExistenciaLotes_Localizaciones_LocalizacionId",
                schema: "H2C",
                table: "ExistenciaLotes");

            migrationBuilder.DropForeignKey(
                name: "FK_ExistenciaLotes_Lotes_LoteId",
                schema: "H2C",
                table: "ExistenciaLotes");

            migrationBuilder.DropForeignKey(
                name: "FK_MovsInventarioDet_AjustesConfig_AjusteConfigId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropForeignKey(
                name: "FK_MovsInventarioDet_Articulos_ArticuloId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropForeignKey(
                name: "FK_MovsInventarioDet_Bodegas_BodegaId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropForeignKey(
                name: "FK_MovsInventarioDet_CentroCuenta_CentroCuentaId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropForeignKey(
                name: "FK_MovsInventarioDet_DocTributarios_DocTributarioId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropForeignKey(
                name: "FK_MovsInventarioDet_Localizaciones_LocalizacionId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropForeignKey(
                name: "FK_MovsInventarioDet_Lotes_LoteId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropForeignKey(
                name: "FK_MovsInventarioDet_UnidadesMedida_unidadMedidaId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropTable(
                name: "TiposOperacion",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "TiposPago",
                schema: "H2C");

            //migrationBuilder.DropIndex(
            //    name: "IxUsuarioAjuste",
            //    schema: "H2C",
            //    table: "UsuarioAjusteInv");

            migrationBuilder.DropIndex(
                name: "IX_MovsInventarioDet_AjusteConfigId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropIndex(
                name: "IX_MovsInventarioDet_ArticuloId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropIndex(
                name: "IX_MovsInventarioDet_BodegaId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropIndex(
                name: "IX_MovsInventarioDet_CentroCuentaId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropIndex(
                name: "IX_MovsInventarioDet_DocTributarioId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropIndex(
                name: "IX_MovsInventarioDet_LocalizacionId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropIndex(
                name: "IX_MovsInventarioDet_LoteId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropIndex(
                name: "IX_MovsInventarioDet_unidadMedidaId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropIndex(
                name: "IxArtLoteSecLote",
                schema: "H2C",
                table: "IngresosLotes");

            migrationBuilder.DropIndex(
                name: "IX_ExistenciaLotes_ArticuloId",
                schema: "H2C",
                table: "ExistenciaLotes");

            migrationBuilder.DropIndex(
                name: "IX_ExistenciaLotes_BodegaId",
                schema: "H2C",
                table: "ExistenciaLotes");

            migrationBuilder.DropIndex(
                name: "IX_ExistenciaLotes_LocalizacionId",
                schema: "H2C",
                table: "ExistenciaLotes");

            migrationBuilder.DropIndex(
                name: "IX_ExistenciaLotes_LoteId",
                schema: "H2C",
                table: "ExistenciaLotes");

            migrationBuilder.DropIndex(
                name: "IxConsecutivoInvUsuario",
                schema: "H2C",
                table: "ConsecutivosInvUsuarios");

            migrationBuilder.DropIndex(
                name: "IxCodConsecutivo",
                schema: "H2C",
                table: "ConsecutivosInv");

            migrationBuilder.DropIndex(
                name: "IxAjusteSubtipo",
                schema: "H2C",
                table: "AjustesSubTipo");

            migrationBuilder.DropIndex(
                name: "IxAjusteSubsubtipo",
                schema: "H2C",
                table: "AjustesSubSubTipo");

            migrationBuilder.DropIndex(
                name: "IxCodAjusteConfig",
                schema: "H2C",
                table: "AjustesConfig");

            migrationBuilder.DropColumn(
                name: "AjusteConfigId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropColumn(
                name: "ArticuloId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropColumn(
                name: "BodegaId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropColumn(
                name: "CentroCuentaId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropColumn(
                name: "DocTributarioId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropColumn(
                name: "LocalizacionId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropColumn(
                name: "LoteId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.DropColumn(
                name: "unidadMedidaId",
                schema: "H2C",
                table: "MovsInventarioDet");

            migrationBuilder.RenameColumn(
                name: "LoteId",
                schema: "H2C",
                table: "ExistenciaLotes",
                newName: "Lote");

            migrationBuilder.RenameColumn(
                name: "LocalizacionId",
                schema: "H2C",
                table: "ExistenciaLotes",
                newName: "Localización");

            migrationBuilder.RenameColumn(
                name: "BodegaId",
                schema: "H2C",
                table: "ExistenciaLotes",
                newName: "Bodega");

            migrationBuilder.RenameColumn(
                name: "ArticuloId",
                schema: "H2C",
                table: "ExistenciaLotes",
                newName: "Articulo");

            migrationBuilder.RenameColumn(
                name: "Subsubtipo",
                schema: "H2C",
                table: "AjustesSubSubTipo",
                newName: "SubsubtipoId");

            migrationBuilder.AlterColumn<string>(
                name: "UnidadDistribucion",
                schema: "H2C",
                table: "MovsInventarioDet",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AjusteConfig",
                schema: "H2C",
                table: "MovsInventarioDet",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Articulo",
                schema: "H2C",
                table: "MovsInventarioDet",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Bodega",
                schema: "H2C",
                table: "MovsInventarioDet",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CentroCosto",
                schema: "H2C",
                table: "MovsInventarioDet",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CuentaContable",
                schema: "H2C",
                table: "MovsInventarioDet",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocTributario",
                schema: "H2C",
                table: "MovsInventarioDet",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Localizacion",
                schema: "H2C",
                table: "MovsInventarioDet",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lote",
                schema: "H2C",
                table: "MovsInventarioDet",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);
        }
    }
}
