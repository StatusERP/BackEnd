using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixModuloInstalado5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Accion",
                schema: "ERPADMIN",
                table: "ModuloInstalado");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
