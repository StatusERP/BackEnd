using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixSubTipoDocCB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CentroCosto",
                schema: "H2C",
                table: "SubTiposDocCB");

            migrationBuilder.DropColumn(
                name: "CuentaContable",
                schema: "H2C",
                table: "SubTiposDocCB");

            migrationBuilder.DropColumn(
                name: "Paquete",
                schema: "H2C",
                table: "SubTiposDocCB");

            migrationBuilder.DropColumn(
                name: "TipoAsiento",
                schema: "H2C",
                table: "SubTiposDocCB");

            migrationBuilder.DropColumn(
                name: "TipoServicio",
                schema: "H2C",
                table: "SubTiposDocCB");

            migrationBuilder.AddColumn<int>(
                name: "CentroCuentaId",
                schema: "H2C",
                table: "SubTiposDocCB",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaqueteId",
                schema: "H2C",
                table: "SubTiposDocCB",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoPartidaId",
                schema: "H2C",
                table: "SubTiposDocCB",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SubTiposDocCB_CentroCuentaId",
                schema: "H2C",
                table: "SubTiposDocCB",
                column: "CentroCuentaId");

            migrationBuilder.CreateIndex(
                name: "IX_SubTiposDocCB_PaqueteId",
                schema: "H2C",
                table: "SubTiposDocCB",
                column: "PaqueteId");

            migrationBuilder.CreateIndex(
                name: "IX_SubTiposDocCB_TipoPartidaId",
                schema: "H2C",
                table: "SubTiposDocCB",
                column: "TipoPartidaId");

            migrationBuilder.CreateIndex(
                name: "IxTipo_SubTipo",
                schema: "H2C",
                table: "SubTiposDocCB",
                columns: new[] { "Tipo", "SubTipo" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SubTiposDocCB_CentroCuenta_CentroCuentaId",
                schema: "H2C",
                table: "SubTiposDocCB",
                column: "CentroCuentaId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubTiposDocCB_PaquetesContables_PaqueteId",
                schema: "H2C",
                table: "SubTiposDocCB",
                column: "PaqueteId",
                principalSchema: "H2C",
                principalTable: "PaquetesContables",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubTiposDocCB_TiposPartida_TipoPartidaId",
                schema: "H2C",
                table: "SubTiposDocCB",
                column: "TipoPartidaId",
                principalSchema: "H2C",
                principalTable: "TiposPartida",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubTiposDocCB_CentroCuenta_CentroCuentaId",
                schema: "H2C",
                table: "SubTiposDocCB");

            migrationBuilder.DropForeignKey(
                name: "FK_SubTiposDocCB_PaquetesContables_PaqueteId",
                schema: "H2C",
                table: "SubTiposDocCB");

            migrationBuilder.DropForeignKey(
                name: "FK_SubTiposDocCB_TiposPartida_TipoPartidaId",
                schema: "H2C",
                table: "SubTiposDocCB");

            migrationBuilder.DropIndex(
                name: "IX_SubTiposDocCB_CentroCuentaId",
                schema: "H2C",
                table: "SubTiposDocCB");

            migrationBuilder.DropIndex(
                name: "IX_SubTiposDocCB_PaqueteId",
                schema: "H2C",
                table: "SubTiposDocCB");

            migrationBuilder.DropIndex(
                name: "IX_SubTiposDocCB_TipoPartidaId",
                schema: "H2C",
                table: "SubTiposDocCB");

            migrationBuilder.DropIndex(
                name: "IxTipo_SubTipo",
                schema: "H2C",
                table: "SubTiposDocCB");

            migrationBuilder.DropColumn(
                name: "CentroCuentaId",
                schema: "H2C",
                table: "SubTiposDocCB");

            migrationBuilder.DropColumn(
                name: "PaqueteId",
                schema: "H2C",
                table: "SubTiposDocCB");

            migrationBuilder.DropColumn(
                name: "TipoPartidaId",
                schema: "H2C",
                table: "SubTiposDocCB");

            migrationBuilder.AddColumn<string>(
                name: "CentroCosto",
                schema: "H2C",
                table: "SubTiposDocCB",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CuentaContable",
                schema: "H2C",
                table: "SubTiposDocCB",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Paquete",
                schema: "H2C",
                table: "SubTiposDocCB",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoAsiento",
                schema: "H2C",
                table: "SubTiposDocCB",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoServicio",
                schema: "H2C",
                table: "SubTiposDocCB",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true);
        }
    }
}
