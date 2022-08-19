using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class DireccEmbarque : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DireccEmbarques",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    DetalleDireccionId = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contacto = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Cargo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Telefono1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telefono2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DireccEmbarques", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DireccEmbarques_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalSchema: "H2C",
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DireccEmbarques_DetalleDirecciones_DetalleDireccionId",
                        column: x => x.DetalleDireccionId,
                        principalSchema: "H2C",
                        principalTable: "DetalleDirecciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DireccEmbarques_DetalleDireccionId",
                schema: "H2C",
                table: "DireccEmbarques",
                column: "DetalleDireccionId");

            migrationBuilder.CreateIndex(
                name: "IxClienteId_Direccion",
                schema: "H2C",
                table: "DireccEmbarques",
                columns: new[] { "ClienteId", "Direccion" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DireccEmbarques",
                schema: "H2C");
        }
    }
}
