using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixGlobCI3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesCI_PaquetesContables_paqueteContableId",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.DropColumn(
                name: "PaqueteId",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.RenameColumn(
                name: "paqueteContableId",
                schema: "H2C",
                table: "GlobalesCI",
                newName: "PaqueteContableId");

            migrationBuilder.RenameIndex(
                name: "IX_GlobalesCI_paqueteContableId",
                schema: "H2C",
                table: "GlobalesCI",
                newName: "IX_GlobalesCI_PaqueteContableId");

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesCI_PaquetesContables_PaqueteContableId",
                schema: "H2C",
                table: "GlobalesCI",
                column: "PaqueteContableId",
                principalSchema: "H2C",
                principalTable: "PaquetesContables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GlobalesCI_PaquetesContables_PaqueteContableId",
                schema: "H2C",
                table: "GlobalesCI");

            migrationBuilder.RenameColumn(
                name: "PaqueteContableId",
                schema: "H2C",
                table: "GlobalesCI",
                newName: "paqueteContableId");

            migrationBuilder.RenameIndex(
                name: "IX_GlobalesCI_PaqueteContableId",
                schema: "H2C",
                table: "GlobalesCI",
                newName: "IX_GlobalesCI_paqueteContableId");

            migrationBuilder.AddColumn<int>(
                name: "PaqueteId",
                schema: "H2C",
                table: "GlobalesCI",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalesCI_PaquetesContables_paqueteContableId",
                schema: "H2C",
                table: "GlobalesCI",
                column: "paqueteContableId",
                principalSchema: "H2C",
                principalTable: "PaquetesContables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
