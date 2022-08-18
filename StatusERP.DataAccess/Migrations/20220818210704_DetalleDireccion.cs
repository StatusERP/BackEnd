using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class DetalleDireccion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetalleDirecciones",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodDetalleDireccion = table.Column<int>(type: "int", nullable: false),
                    DireccionId = table.Column<int>(type: "int", nullable: false),
                    Campo01 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Campo02 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Campo03 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Campo04 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Campo05 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Campo06 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Campo07 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Campo08 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Campo09 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Campo10 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleDirecciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleDirecciones_Direcciones_DireccionId",
                        column: x => x.DireccionId,
                        principalSchema: "H2C",
                        principalTable: "Direcciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetalleDirecciones_DireccionId",
                schema: "H2C",
                table: "DetalleDirecciones",
                column: "DireccionId");

            migrationBuilder.CreateIndex(
                name: "IxCodDetalleDireccion",
                schema: "H2C",
                table: "DetalleDirecciones",
                column: "CodDetalleDireccion",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleDirecciones",
                schema: "H2C");
        }
    }
}
