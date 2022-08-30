using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class Fix2Cliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rubro3_Cliente",
                schema: "H2C",
                table: "Clientes",
                newName: "Rubro3Cliente");

            migrationBuilder.RenameColumn(
                name: "Rubro2_Cliente",
                schema: "H2C",
                table: "Clientes",
                newName: "Rubro2Cliente");

            migrationBuilder.RenameColumn(
                name: "Rubro1_Cliente",
                schema: "H2C",
                table: "Clientes",
                newName: "Rubro1Cliente");

            migrationBuilder.AddColumn<string>(
                name: "PassAPIRecepcion",
                schema: "H2C",
                table: "Clientes",
                type: "nvarchar(254)",
                maxLength: 254,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PassAPIRecepcion",
                schema: "H2C",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "Rubro3Cliente",
                schema: "H2C",
                table: "Clientes",
                newName: "Rubro3_Cliente");

            migrationBuilder.RenameColumn(
                name: "Rubro2Cliente",
                schema: "H2C",
                table: "Clientes",
                newName: "Rubro2_Cliente");

            migrationBuilder.RenameColumn(
                name: "Rubro1Cliente",
                schema: "H2C",
                table: "Clientes",
                newName: "Rubro1_Cliente");
        }
    }
}
