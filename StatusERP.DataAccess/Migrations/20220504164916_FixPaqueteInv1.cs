using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class FixPaqueteInv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "H2C");

            migrationBuilder.CreateTable(
                name: "PaquetesInv",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodPaqueteInv = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    UltimoUsuario = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    UsuarioCreador = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    FechaUltAcceso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                    constraints: table =>
                    {
                       table.PrimaryKey("PK_PaquetesInv", x => x.Id);
                    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaquetesInv",
                schema: "H2C");
        }
    }
}
