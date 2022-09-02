using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixSubTipoDocCC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CentroCosto",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.DropColumn(
                name: "CodigoHacienda",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.DropColumn(
                name: "ConsecutivoFac",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.DropColumn(
                name: "CuentaContable",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.DropColumn(
                name: "Paquete",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.DropColumn(
                name: "SubTipoCB",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.DropColumn(
                name: "TipoAsiento",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.DropColumn(
                name: "TipoCB",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.DropColumn(
                name: "TipoPago",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.DropColumn(
                name: "TipoServicio",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.AddColumn<int>(
                name: "CentroCuentaId",
                schema: "H2C",
                table: "SubTiposDocCC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConsecutivoFacId",
                schema: "H2C",
                table: "SubTiposDocCC",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaqueteId",
                schema: "H2C",
                table: "SubTiposDocCC",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubTipoCBId",
                schema: "H2C",
                table: "SubTiposDocCC",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoPartidaId",
                schema: "H2C",
                table: "SubTiposDocCC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SubTiposDocCC_CentroCuentaId",
                schema: "H2C",
                table: "SubTiposDocCC",
                column: "CentroCuentaId");

            migrationBuilder.CreateIndex(
                name: "IX_SubTiposDocCC_ConsecutivoFacId",
                schema: "H2C",
                table: "SubTiposDocCC",
                column: "ConsecutivoFacId");

            migrationBuilder.CreateIndex(
                name: "IX_SubTiposDocCC_PaqueteId",
                schema: "H2C",
                table: "SubTiposDocCC",
                column: "PaqueteId");

            migrationBuilder.CreateIndex(
                name: "IX_SubTiposDocCC_SubTipoCBId",
                schema: "H2C",
                table: "SubTiposDocCC",
                column: "SubTipoCBId");

            migrationBuilder.CreateIndex(
                name: "IX_SubTiposDocCC_TipoPartidaId",
                schema: "H2C",
                table: "SubTiposDocCC",
                column: "TipoPartidaId");

            migrationBuilder.CreateIndex(
                name: "IxTipo_Subtipo",
                schema: "H2C",
                table: "SubTiposDocCC",
                columns: new[] { "Tipo", "Subtipo" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SubTiposDocCC_CentroCuenta_CentroCuentaId",
                schema: "H2C",
                table: "SubTiposDocCC",
                column: "CentroCuentaId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubTiposDocCC_ConsecutivosFA_ConsecutivoFacId",
                schema: "H2C",
                table: "SubTiposDocCC",
                column: "ConsecutivoFacId",
                principalSchema: "H2C",
                principalTable: "ConsecutivosFA",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubTiposDocCC_PaquetesContables_PaqueteId",
                schema: "H2C",
                table: "SubTiposDocCC",
                column: "PaqueteId",
                principalSchema: "H2C",
                principalTable: "PaquetesContables",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubTiposDocCC_SubTiposDocCB_SubTipoCBId",
                schema: "H2C",
                table: "SubTiposDocCC",
                column: "SubTipoCBId",
                principalSchema: "H2C",
                principalTable: "SubTiposDocCB",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubTiposDocCC_TiposPartida_TipoPartidaId",
                schema: "H2C",
                table: "SubTiposDocCC",
                column: "TipoPartidaId",
                principalSchema: "H2C",
                principalTable: "TiposPartida",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubTiposDocCC_CentroCuenta_CentroCuentaId",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.DropForeignKey(
                name: "FK_SubTiposDocCC_ConsecutivosFA_ConsecutivoFacId",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.DropForeignKey(
                name: "FK_SubTiposDocCC_PaquetesContables_PaqueteId",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.DropForeignKey(
                name: "FK_SubTiposDocCC_SubTiposDocCB_SubTipoCBId",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.DropForeignKey(
                name: "FK_SubTiposDocCC_TiposPartida_TipoPartidaId",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.DropIndex(
                name: "IX_SubTiposDocCC_CentroCuentaId",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.DropIndex(
                name: "IX_SubTiposDocCC_ConsecutivoFacId",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.DropIndex(
                name: "IX_SubTiposDocCC_PaqueteId",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.DropIndex(
                name: "IX_SubTiposDocCC_SubTipoCBId",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.DropIndex(
                name: "IX_SubTiposDocCC_TipoPartidaId",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.DropIndex(
                name: "IxTipo_Subtipo",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.DropColumn(
                name: "CentroCuentaId",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.DropColumn(
                name: "ConsecutivoFacId",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.DropColumn(
                name: "PaqueteId",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.DropColumn(
                name: "SubTipoCBId",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.DropColumn(
                name: "TipoPartidaId",
                schema: "H2C",
                table: "SubTiposDocCC");

            migrationBuilder.AddColumn<string>(
                name: "CentroCosto",
                schema: "H2C",
                table: "SubTiposDocCC",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodigoHacienda",
                schema: "H2C",
                table: "SubTiposDocCC",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConsecutivoFac",
                schema: "H2C",
                table: "SubTiposDocCC",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CuentaContable",
                schema: "H2C",
                table: "SubTiposDocCC",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Paquete",
                schema: "H2C",
                table: "SubTiposDocCC",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "SubTipoCB",
                schema: "H2C",
                table: "SubTiposDocCC",
                type: "smallint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoAsiento",
                schema: "H2C",
                table: "SubTiposDocCC",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoCB",
                schema: "H2C",
                table: "SubTiposDocCC",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoPago",
                schema: "H2C",
                table: "SubTiposDocCC",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoServicio",
                schema: "H2C",
                table: "SubTiposDocCC",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true);
        }
    }
}
