using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixGlobCI1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Paquete",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.AlterColumn<int>(
                name: "TipoAsiento",
                schema: "H2C",
                table: "GlobalesCI",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaqueteId",
                schema: "H2C",
                table: "GlobalesCI",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "paqueteContableId",
                schema: "H2C",
                table: "GlobalesCI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tipoPartidaId",
                schema: "H2C",
                table: "GlobalesCI",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesCI_paqueteContableId",
                schema: "H2C",
                table: "GlobalesCI",
                column: "paqueteContableId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesCI_tipoPartidaId",
                schema: "H2C",
                table: "GlobalesCI",
                column: "tipoPartidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesCI_PaquetesContables_paqueteContableId",
                schema: "H2C",
                table: "GlobalesCI",
                column: "paqueteContableId",
                principalSchema: "H2C",
                principalTable: "PaquetesContables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesCI_TiposPartida_tipoPartidaId",
                schema: "H2C",
                table: "GlobalesCI",
                column: "tipoPartidaId",
                principalSchema: "H2C",
                principalTable: "TiposPartida",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesCI_PaquetesContables_paqueteContableId",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesCI_TiposPartida_tipoPartidaId",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesCI_paqueteContableId",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesCI_tipoPartidaId",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "PaqueteId",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "paqueteContableId",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "tipoPartidaId",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.AlterColumn<string>(
                name: "TipoAsiento",
                schema: "H2C",
                table: "GlobalesCI",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Paquete",
                schema: "H2C",
                table: "GlobalesCI",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);
        }
    }
}
