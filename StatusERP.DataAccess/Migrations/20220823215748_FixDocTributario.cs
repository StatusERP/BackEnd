using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixDocTributario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CodDocTributario",
                schema: "H2C",
                table: "DocTributarios",
                newName: "NumDocTributario");

            migrationBuilder.AddColumn<int>(
                name: "TipoDocTributarioId",
                schema: "H2C",
                table: "DocTributarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DocTributarios_TipoDocTributarioId",
                schema: "H2C",
                table: "DocTributarios",
                column: "TipoDocTributarioId");

            migrationBuilder.CreateIndex(
                name: "IxNumDocT",
                schema: "H2C",
                table: "DocTributarios",
                column: "NumDocTributario",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DocTributarios_TiposDocTributarios_TipoDocTributarioId",
                schema: "H2C",
                table: "DocTributarios",
                column: "TipoDocTributarioId",
                principalSchema: "H2C",
                principalTable: "TiposDocTributarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocTributarios_TiposDocTributarios_TipoDocTributarioId",
                schema: "H2C",
                table: "DocTributarios");

            migrationBuilder.DropIndex(
                name: "IX_DocTributarios_TipoDocTributarioId",
                schema: "H2C",
                table: "DocTributarios");

            migrationBuilder.DropIndex(
                name: "IxNumDocT",
                schema: "H2C",
                table: "DocTributarios");

            migrationBuilder.DropColumn(
                name: "TipoDocTributarioId",
                schema: "H2C",
                table: "DocTributarios");

            migrationBuilder.RenameColumn(
                name: "NumDocTributario",
                schema: "H2C",
                table: "DocTributarios",
                newName: "CodDocTributario");
        }
    }
}
