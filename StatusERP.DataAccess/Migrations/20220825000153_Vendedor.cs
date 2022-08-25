using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class Vendedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Vendedor",
                schema: "H2C",
                table: "Vendedores",
                newName: "CodVendedor");

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                schema: "H2C",
                table: "Vendedores",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IxCodVendedor",
                schema: "H2C",
                table: "Vendedores",
                column: "CodVendedor",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IxCodVendedor",
                schema: "H2C",
                table: "Vendedores");

            migrationBuilder.DropColumn(
                name: "Telefono",
                schema: "H2C",
                table: "Vendedores");

            migrationBuilder.RenameColumn(
                name: "CodVendedor",
                schema: "H2C",
                table: "Vendedores",
                newName: "Vendedor");
        }
    }
}
