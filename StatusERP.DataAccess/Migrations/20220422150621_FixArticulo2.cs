using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixArticulo2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_Impuestos_ImpuestoFKId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Impuesto",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.RenameColumn(
                name: "ImpuestoFKId",
                schema: "H2C",
                table: "Articulos",
                newName: "ImpuestoId");

            migrationBuilder.RenameIndex(
                name: "IX_Articulos_ImpuestoFKId",
                schema: "H2C",
                table: "Articulos",
                newName: "IX_Articulos_ImpuestoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_Impuestos_ImpuestoId",
                schema: "H2C",
                table: "Articulos",
                column: "ImpuestoId",
                principalSchema: "H2C",
                principalTable: "Impuestos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_Impuestos_ImpuestoId",
                schema: "H2C",
                table: "Articulos");

            migrationBuilder.RenameColumn(
                name: "ImpuestoId",
                schema: "H2C",
                table: "Articulos",
                newName: "ImpuestoFKId");

            migrationBuilder.RenameIndex(
                name: "IX_Articulos_ImpuestoId",
                schema: "H2C",
                table: "Articulos",
                newName: "IX_Articulos_ImpuestoFKId");

            migrationBuilder.AddColumn<int>(
                name: "Impuesto",
                schema: "H2C",
                table: "Articulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_Impuestos_ImpuestoFKId",
                schema: "H2C",
                table: "Articulos",
                column: "ImpuestoFKId",
                principalSchema: "H2C",
                principalTable: "Impuestos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
