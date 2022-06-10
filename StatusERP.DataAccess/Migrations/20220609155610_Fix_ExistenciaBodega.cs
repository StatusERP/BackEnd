using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class Fix_ExistenciaBodega : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UltimoUsuario",
                schema: "H2C",
                table: "ExistenciaBodega");

            migrationBuilder.DropColumn(
                name: "UsuarioCreador",
                schema: "H2C",
                table: "ExistenciaBodega");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "UsuarioCreador",
                schema: "H2C",
                table: "ExistenciaBodega",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");


            migrationBuilder.AddColumn<string>(
                name: "UltimoUsuario",
                schema: "H2C",
                table: "ExistenciaBodega",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "");
        }
    }
}
