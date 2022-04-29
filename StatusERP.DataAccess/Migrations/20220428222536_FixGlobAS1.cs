using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixGlobAS1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MonedaDolar",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.DropColumn(
                name: "MonedaLocal",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.AddColumn<int>(
                name: "MonedaDolarId",
                schema: "H2C",
                table: "GlobalesAS",
                type: "int",
                maxLength: 4,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MonedaLocalId",
                schema: "H2C",
                table: "GlobalesAS",
                type: "int",
                maxLength: 4,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesAS_MonedaDolarId",
                schema: "H2C",
                table: "GlobalesAS",
                column: "MonedaDolarId");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalesAS_MonedaLocalId",
                schema: "H2C",
                table: "GlobalesAS",
                column: "MonedaLocalId");

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesAS_Monedas_MonedaDolarId",
                schema: "H2C",
                table: "GlobalesAS",
                column: "MonedaDolarId",
                principalSchema: "H2C",
                principalTable: "Monedas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesAS_Monedas_MonedaLocalId",
                schema: "H2C",
                table: "GlobalesAS",
                column: "MonedaLocalId",
                principalSchema: "H2C",
                principalTable: "Monedas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesAS_Monedas_MonedaDolarId",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesAS_Monedas_MonedaLocalId",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesAS_MonedaDolarId",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.DropIndex(
                name: "IX_GlobalesAS_MonedaLocalId",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.DropColumn(
                name: "MonedaDolarId",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.DropColumn(
                name: "MonedaLocalId",
                schema: "H2C",
                table: "GlobalesAS");

            migrationBuilder.AddColumn<string>(
                name: "MonedaDolar",
                schema: "H2C",
                table: "GlobalesAS",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MonedaLocal",
                schema: "H2C",
                table: "GlobalesAS",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");
        }
    }
}
