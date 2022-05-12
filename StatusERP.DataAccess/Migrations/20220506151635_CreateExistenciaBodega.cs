using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class CreateExistenciaBodega : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                           name: "H2C");

            migrationBuilder.CreateTable(
                name: "ExistenciaBodega",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticuloId = table.Column<int>(type: "int", nullable: false),
                    BodegaId = table.Column<int>(type: "int", nullable: false),
                    ExistenciaMinima = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    ExistenciaMaxima = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PuntoDeOrden = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantDisponible = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantReservada = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantNoAprobada = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantVencida = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantTransito = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantProduccion  = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantPedida = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CantRemitida = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Congelado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCong = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BloqueaTrans = table.Column<bool>(type: "bit", nullable: false),
                    FechaDescong  = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CostoUntPromedioLoc = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CostoUntPromedioDol = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
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
                        table.PrimaryKey("PK_ExistenciaBodega", x => x.Id);
                    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
               name: "ExistenciaBodega",
               schema: "H2C");
        }
    }
}
