using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixUsAjusteInv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)

        {
            migrationBuilder.CreateTable(
                name: "UsuarioAjusteInv",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    AjusteConfig = table.Column<string>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioAjusteInv", x => x.Id);
                });


            migrationBuilder.CreateIndex(
                name: "IxUsuarioAjusteInv_UsAj",
                schema: "H2C",
                table: "UsuarioAjusteInv",
                columns: new[] { "Usuario", "AjusteConfig" },
                unique: true);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.DropIndex(
                name: "IxUsuarioAjusteInv_UsAj",
                schema: "H2C",
                table: "UsuarioAjusteInv");

            migrationBuilder.DropTable(
                name: "UsuarioAjusteInv",
                schema: "H2C");
        }
    }
}
