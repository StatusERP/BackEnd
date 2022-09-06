using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixPedidoEnc3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cliente",
                schema: "H2C",
                table: "PedidoEncs",
                newName: "CodCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CodCliente",
                schema: "H2C",
                table: "PedidoEncs",
                newName: "Cliente");
        }
    }
}
