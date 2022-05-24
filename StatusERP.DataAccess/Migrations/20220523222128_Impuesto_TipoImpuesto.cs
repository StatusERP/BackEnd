using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class Impuesto_TipoImpuesto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Impuestos_CentroCuenta_CtroCtaImp1",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtaImp1DesComp",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtaImp1DevComp",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtaImp1DevVentas",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtaImp1GenVts",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtaImp2DesComp",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtaImp2DevComp",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtaImp2DevVentas",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtaImp2Gen",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtaImp2GenVts",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtrImp1DesComp",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtrImp1DevComp",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtrImp1DevVentas",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtrImp1GenVts",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtrImp2DesComp",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtrImp2DevComp",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtrImp2DevVentas",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtrImp2Gen",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtrImp2GenVts",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "TipoImpuesto1",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "TipoImpuesto2",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.RenameColumn(
                name: "CtroCtaImp1",
                schema: "H2C",
                table: "Impuestos",
                newName: "TipoImpuesto2Id");

            migrationBuilder.RenameIndex(
                name: "IX_Impuestos_CtroCtaImp1",
                schema: "H2C",
                table: "Impuestos",
                newName: "IX_Impuestos_TipoImpuesto2Id");

            migrationBuilder.AddColumn<int>(
                name: "CtroCtaImp1DescCompId",
                schema: "H2C",
                table: "Impuestos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtroCtaImp1DevCompId",
                schema: "H2C",
                table: "Impuestos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtroCtaImp1DevVtsId",
                schema: "H2C",
                table: "Impuestos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtroCtaImp1GenId",
                schema: "H2C",
                table: "Impuestos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtroCtaImp1GenVtsId",
                schema: "H2C",
                table: "Impuestos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtroCtaImp2DescCompId",
                schema: "H2C",
                table: "Impuestos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtroCtaImp2DevCompId",
                schema: "H2C",
                table: "Impuestos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtroCtaImp2DevVtsId",
                schema: "H2C",
                table: "Impuestos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtroCtaImp2GenId",
                schema: "H2C",
                table: "Impuestos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CtroCtaImp2GenVtsId",
                schema: "H2C",
                table: "Impuestos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoImpuesto1Id",
                schema: "H2C",
                table: "Impuestos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TiposImpuesto",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodTipoImpuesto = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposImpuesto", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Impuestos_CtroCtaImp1DescCompId",
                schema: "H2C",
                table: "Impuestos",
                column: "CtroCtaImp1DescCompId");

            migrationBuilder.CreateIndex(
                name: "IX_Impuestos_CtroCtaImp1DevCompId",
                schema: "H2C",
                table: "Impuestos",
                column: "CtroCtaImp1DevCompId");

            migrationBuilder.CreateIndex(
                name: "IX_Impuestos_CtroCtaImp1DevVtsId",
                schema: "H2C",
                table: "Impuestos",
                column: "CtroCtaImp1DevVtsId");

            migrationBuilder.CreateIndex(
                name: "IX_Impuestos_CtroCtaImp1GenId",
                schema: "H2C",
                table: "Impuestos",
                column: "CtroCtaImp1GenId");

            migrationBuilder.CreateIndex(
                name: "IX_Impuestos_CtroCtaImp1GenVtsId",
                schema: "H2C",
                table: "Impuestos",
                column: "CtroCtaImp1GenVtsId");

            migrationBuilder.CreateIndex(
                name: "IX_Impuestos_CtroCtaImp2DescCompId",
                schema: "H2C",
                table: "Impuestos",
                column: "CtroCtaImp2DescCompId");

            migrationBuilder.CreateIndex(
                name: "IX_Impuestos_CtroCtaImp2DevCompId",
                schema: "H2C",
                table: "Impuestos",
                column: "CtroCtaImp2DevCompId");

            migrationBuilder.CreateIndex(
                name: "IX_Impuestos_CtroCtaImp2DevVtsId",
                schema: "H2C",
                table: "Impuestos",
                column: "CtroCtaImp2DevVtsId");

            migrationBuilder.CreateIndex(
                name: "IX_Impuestos_CtroCtaImp2GenId",
                schema: "H2C",
                table: "Impuestos",
                column: "CtroCtaImp2GenId");

            migrationBuilder.CreateIndex(
                name: "IX_Impuestos_CtroCtaImp2GenVtsId",
                schema: "H2C",
                table: "Impuestos",
                column: "CtroCtaImp2GenVtsId");

            migrationBuilder.CreateIndex(
                name: "IX_Impuestos_TipoImpuesto1Id",
                schema: "H2C",
                table: "Impuestos",
                column: "TipoImpuesto1Id");

            migrationBuilder.CreateIndex(
                name: "IxCodImpuesto",
                schema: "H2C",
                table: "Impuestos",
                column: "CodImpuesto",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IxCodTipoImpuesto",
                schema: "H2C",
                table: "TiposImpuesto",
                column: "CodTipoImpuesto",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Impuestos_CentroCuenta_CtroCtaImp1DescCompId",
                schema: "H2C",
                table: "Impuestos",
                column: "CtroCtaImp1DescCompId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Impuestos_CentroCuenta_CtroCtaImp1DevCompId",
                schema: "H2C",
                table: "Impuestos",
                column: "CtroCtaImp1DevCompId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Impuestos_CentroCuenta_CtroCtaImp1DevVtsId",
                schema: "H2C",
                table: "Impuestos",
                column: "CtroCtaImp1DevVtsId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Impuestos_CentroCuenta_CtroCtaImp1GenId",
                schema: "H2C",
                table: "Impuestos",
                column: "CtroCtaImp1GenId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Impuestos_CentroCuenta_CtroCtaImp1GenVtsId",
                schema: "H2C",
                table: "Impuestos",
                column: "CtroCtaImp1GenVtsId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Impuestos_CentroCuenta_CtroCtaImp2DescCompId",
                schema: "H2C",
                table: "Impuestos",
                column: "CtroCtaImp2DescCompId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Impuestos_CentroCuenta_CtroCtaImp2DevCompId",
                schema: "H2C",
                table: "Impuestos",
                column: "CtroCtaImp2DevCompId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Impuestos_CentroCuenta_CtroCtaImp2DevVtsId",
                schema: "H2C",
                table: "Impuestos",
                column: "CtroCtaImp2DevVtsId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Impuestos_CentroCuenta_CtroCtaImp2GenId",
                schema: "H2C",
                table: "Impuestos",
                column: "CtroCtaImp2GenId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Impuestos_CentroCuenta_CtroCtaImp2GenVtsId",
                schema: "H2C",
                table: "Impuestos",
                column: "CtroCtaImp2GenVtsId",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Impuestos_TiposImpuesto_TipoImpuesto1Id",
                schema: "H2C",
                table: "Impuestos",
                column: "TipoImpuesto1Id",
                principalSchema: "H2C",
                principalTable: "TiposImpuesto",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Impuestos_TiposImpuesto_TipoImpuesto2Id",
                schema: "H2C",
                table: "Impuestos",
                column: "TipoImpuesto2Id",
                principalSchema: "H2C",
                principalTable: "TiposImpuesto",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Impuestos_CentroCuenta_CtroCtaImp1DescCompId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropForeignKey(
                name: "FK_Impuestos_CentroCuenta_CtroCtaImp1DevCompId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropForeignKey(
                name: "FK_Impuestos_CentroCuenta_CtroCtaImp1DevVtsId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropForeignKey(
                name: "FK_Impuestos_CentroCuenta_CtroCtaImp1GenId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropForeignKey(
                name: "FK_Impuestos_CentroCuenta_CtroCtaImp1GenVtsId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropForeignKey(
                name: "FK_Impuestos_CentroCuenta_CtroCtaImp2DescCompId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropForeignKey(
                name: "FK_Impuestos_CentroCuenta_CtroCtaImp2DevCompId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropForeignKey(
                name: "FK_Impuestos_CentroCuenta_CtroCtaImp2DevVtsId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropForeignKey(
                name: "FK_Impuestos_CentroCuenta_CtroCtaImp2GenId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropForeignKey(
                name: "FK_Impuestos_CentroCuenta_CtroCtaImp2GenVtsId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropForeignKey(
                name: "FK_Impuestos_TiposImpuesto_TipoImpuesto1Id",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropForeignKey(
                name: "FK_Impuestos_TiposImpuesto_TipoImpuesto2Id",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropTable(
                name: "TiposImpuesto",
                schema: "H2C");

            migrationBuilder.DropIndex(
                name: "IX_Impuestos_CtroCtaImp1DescCompId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropIndex(
                name: "IX_Impuestos_CtroCtaImp1DevCompId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropIndex(
                name: "IX_Impuestos_CtroCtaImp1DevVtsId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropIndex(
                name: "IX_Impuestos_CtroCtaImp1GenId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropIndex(
                name: "IX_Impuestos_CtroCtaImp1GenVtsId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropIndex(
                name: "IX_Impuestos_CtroCtaImp2DescCompId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropIndex(
                name: "IX_Impuestos_CtroCtaImp2DevCompId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropIndex(
                name: "IX_Impuestos_CtroCtaImp2DevVtsId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropIndex(
                name: "IX_Impuestos_CtroCtaImp2GenId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropIndex(
                name: "IX_Impuestos_CtroCtaImp2GenVtsId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropIndex(
                name: "IX_Impuestos_TipoImpuesto1Id",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropIndex(
                name: "IxCodImpuesto",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtroCtaImp1DescCompId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtroCtaImp1DevCompId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtroCtaImp1DevVtsId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtroCtaImp1GenId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtroCtaImp1GenVtsId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtroCtaImp2DescCompId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtroCtaImp2DevCompId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtroCtaImp2DevVtsId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtroCtaImp2GenId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "CtroCtaImp2GenVtsId",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.DropColumn(
                name: "TipoImpuesto1Id",
                schema: "H2C",
                table: "Impuestos");

            migrationBuilder.RenameColumn(
                name: "TipoImpuesto2Id",
                schema: "H2C",
                table: "Impuestos",
                newName: "CtroCtaImp1");

            migrationBuilder.RenameIndex(
                name: "IX_Impuestos_TipoImpuesto2Id",
                schema: "H2C",
                table: "Impuestos",
                newName: "IX_Impuestos_CtroCtaImp1");

            migrationBuilder.AddColumn<string>(
                name: "CtaImp1DesComp",
                schema: "H2C",
                table: "Impuestos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaImp1DevComp",
                schema: "H2C",
                table: "Impuestos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaImp1DevVentas",
                schema: "H2C",
                table: "Impuestos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaImp1GenVts",
                schema: "H2C",
                table: "Impuestos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaImp2DesComp",
                schema: "H2C",
                table: "Impuestos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaImp2DevComp",
                schema: "H2C",
                table: "Impuestos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaImp2DevVentas",
                schema: "H2C",
                table: "Impuestos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaImp2Gen",
                schema: "H2C",
                table: "Impuestos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtaImp2GenVts",
                schema: "H2C",
                table: "Impuestos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrImp1DesComp",
                schema: "H2C",
                table: "Impuestos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrImp1DevComp",
                schema: "H2C",
                table: "Impuestos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrImp1DevVentas",
                schema: "H2C",
                table: "Impuestos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrImp1GenVts",
                schema: "H2C",
                table: "Impuestos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrImp2DesComp",
                schema: "H2C",
                table: "Impuestos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrImp2DevComp",
                schema: "H2C",
                table: "Impuestos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrImp2DevVentas",
                schema: "H2C",
                table: "Impuestos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrImp2Gen",
                schema: "H2C",
                table: "Impuestos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CtrImp2GenVts",
                schema: "H2C",
                table: "Impuestos",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoImpuesto1",
                schema: "H2C",
                table: "Impuestos",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoImpuesto2",
                schema: "H2C",
                table: "Impuestos",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Impuestos_CentroCuenta_CtroCtaImp1",
                schema: "H2C",
                table: "Impuestos",
                column: "CtroCtaImp1",
                principalSchema: "H2C",
                principalTable: "CentroCuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
