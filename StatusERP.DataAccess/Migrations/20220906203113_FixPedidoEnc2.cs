using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixPedidoEnc2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormaPago",
                schema: "H2C",
                table: "PedidoEncs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FormaPago",
                schema: "H2C",
                table: "PedidoEncs",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);
        }
    }
}
