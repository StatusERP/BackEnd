using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class TablasFC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetallesInversiones",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Consecutivo = table.Column<int>(type: "int", nullable: false),
                    FechaInversion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Inversion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MontoDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesInversiones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetallesProyecciones",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Consecutivo = table.Column<int>(type: "int", nullable: false),
                    FechaProyeccion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Proyeccion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MontoDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PorcRecuperacion = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesProyecciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlujosCaja",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaInicial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlujoCajaCod = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoPeriodo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlujosCaja", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GlobalesFC",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntegracionCC = table.Column<bool>(type: "bit", nullable: false),
                    IntegracionCO = table.Column<bool>(type: "bit", nullable: false),
                    IntegracionCP = table.Column<bool>(type: "bit", nullable: false),
                    IntegracionFA = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalesFC", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inversiones",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CodInversion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MontoTotalDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoTotalLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Naturaleza = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    DocTributarioId = table.Column<int>(type: "int", nullable: true),
                    TipoCambio = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inversiones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inversiones_DocTributarios_DocTributarioId",
                        column: x => x.DocTributarioId,
                        principalSchema: "H2C",
                        principalTable: "DocTributarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Proyecciones",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Asiento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CodProyeccion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MontoTotalDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoTotalLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Naturaleza = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    DocTributarioId = table.Column<int>(type: "int", nullable: true),
                    Origen = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoCambio = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyecciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proyecciones_DocTributarios_DocTributarioId",
                        column: x => x.DocTributarioId,
                        principalSchema: "H2C",
                        principalTable: "DocTributarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CalculosFC",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsecutivoPeriodo = table.Column<int>(type: "int", nullable: false),
                    Editado = table.Column<bool>(type: "bit", nullable: false),
                    FlujoCajaId = table.Column<int>(type: "int", nullable: false),
                    MontoTotalDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoTotalDolarEje = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoTotalLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoTotalLocalEje = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Naturaleza = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    RubroHijo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RubroPadre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TipoCalculo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculosFC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalculosFC_FlujosCaja_FlujoCajaId",
                        column: x => x.FlujoCajaId,
                        principalSchema: "H2C",
                        principalTable: "FlujosCaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChequesRubroFC",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChequeInterno = table.Column<int>(type: "int", nullable: false),
                    CuentaBancoId = table.Column<int>(type: "int", nullable: false),
                    CuentaBancariaId = table.Column<int>(type: "int", nullable: false),
                    FlujoCajaId = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Naturaleza = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    RubroHijo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RubroPadre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SubTipo = table.Column<short>(type: "smallint", nullable: false),
                    TipoDocumento = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChequesRubroFC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChequesRubroFC_CuentasBancarias_CuentaBancariaId",
                        column: x => x.CuentaBancariaId,
                        principalSchema: "H2C",
                        principalTable: "CuentasBancarias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChequesRubroFC_FlujosCaja_FlujoCajaId",
                        column: x => x.FlujoCajaId,
                        principalSchema: "H2C",
                        principalTable: "FlujosCaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallesFC",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Asiento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Consecutivo = table.Column<int>(type: "int", nullable: false),
                    ConsecutivoPeriodo = table.Column<int>(type: "int", nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    FlujoCajaId = table.Column<int>(type: "int", nullable: false),
                    MontoDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Naturaleza = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Origen = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Propietario = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    RubroHijo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RubroPadre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesFC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetallesFC_FlujosCaja_FlujoCajaId",
                        column: x => x.FlujoCajaId,
                        principalSchema: "H2C",
                        principalTable: "FlujosCaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallesFCEjecuta",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Consecutivo = table.Column<int>(type: "int", nullable: false),
                    ConsecutivoPeriodo = table.Column<int>(type: "int", nullable: false),
                    FlujoCajaId = table.Column<int>(type: "int", nullable: false),
                    MontoDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Naturaleza = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    RubroHijo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RubroPadre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SubTipo = table.Column<short>(type: "smallint", nullable: false),
                    TipoDocumento = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesFCEjecuta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetallesFCEjecuta_FlujosCaja_FlujoCajaId",
                        column: x => x.FlujoCajaId,
                        principalSchema: "H2C",
                        principalTable: "FlujosCaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FCCuentasBancos",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    CuentaBancoId = table.Column<int>(type: "int", nullable: false),
                    CuentaBancariaId = table.Column<int>(type: "int", nullable: false),
                    FlujoCajaId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FCCuentasBancos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FCCuentasBancos_CuentasBancarias_CuentaBancariaId",
                        column: x => x.CuentaBancariaId,
                        principalSchema: "H2C",
                        principalTable: "CuentasBancarias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FCCuentasBancos_FlujosCaja_FlujoCajaId",
                        column: x => x.FlujoCajaId,
                        principalSchema: "H2C",
                        principalTable: "FlujosCaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovBancosRubroFC",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Consecutivo = table.Column<int>(type: "int", nullable: false),
                    CuentaBancariaid = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FlujoCajaId = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Naturaleza = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Numero = table.Column<decimal>(type: "decimal(28,0)", nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    RubroHijo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RubroPadre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SubTipo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    TCDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TCLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoDocumento = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovBancosRubroFC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovBancosRubroFC_CuentasBancarias_CuentaBancariaid",
                        column: x => x.CuentaBancariaid,
                        principalSchema: "H2C",
                        principalTable: "CuentasBancarias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovBancosRubroFC_FlujosCaja_FlujoCajaId",
                        column: x => x.FlujoCajaId,
                        principalSchema: "H2C",
                        principalTable: "FlujosCaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PeriodosFC",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Consecutivo = table.Column<int>(type: "int", nullable: false),
                    FechaFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaInicial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FlujoCajaId = table.Column<int>(type: "int", nullable: false),
                    TipoPeriodo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodosFC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PeriodosFC_FlujosCaja_FlujoCajaId",
                        column: x => x.FlujoCajaId,
                        principalSchema: "H2C",
                        principalTable: "FlujosCaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RubrosFC",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    FlujoCajaId = table.Column<int>(type: "int", nullable: false),
                    Formula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormulaTXT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Naturaleza = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    RubroHijo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RubroPadre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TipoRubro = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RubrosFC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RubrosFC_FlujosCaja_FlujoCajaId",
                        column: x => x.FlujoCajaId,
                        principalSchema: "H2C",
                        principalTable: "FlujosCaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VersionesFC",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FechaCalculo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaHistorico = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaInicial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlujoCajaId = table.Column<int>(type: "int", nullable: false),
                    UsuarioCalculo = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    UsuarioHistorico = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionesFC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VersionesFC_FlujosCaja_FlujoCajaId",
                        column: x => x.FlujoCajaId,
                        principalSchema: "H2C",
                        principalTable: "FlujosCaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CalculosFC_FlujoCajaId",
                schema: "H2C",
                table: "CalculosFC",
                column: "FlujoCajaId");

            migrationBuilder.CreateIndex(
                name: "IX_ChequesRubroFC_CuentaBancariaId",
                schema: "H2C",
                table: "ChequesRubroFC",
                column: "CuentaBancariaId");

            migrationBuilder.CreateIndex(
                name: "IX_ChequesRubroFC_FlujoCajaId",
                schema: "H2C",
                table: "ChequesRubroFC",
                column: "FlujoCajaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesFC_FlujoCajaId",
                schema: "H2C",
                table: "DetallesFC",
                column: "FlujoCajaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesFCEjecuta_FlujoCajaId",
                schema: "H2C",
                table: "DetallesFCEjecuta",
                column: "FlujoCajaId");

            migrationBuilder.CreateIndex(
                name: "IX_FCCuentasBancos_CuentaBancariaId",
                schema: "H2C",
                table: "FCCuentasBancos",
                column: "CuentaBancariaId");

            migrationBuilder.CreateIndex(
                name: "IX_FCCuentasBancos_FlujoCajaId",
                schema: "H2C",
                table: "FCCuentasBancos",
                column: "FlujoCajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Inversiones_DocTributarioId",
                schema: "H2C",
                table: "Inversiones",
                column: "DocTributarioId");

            migrationBuilder.CreateIndex(
                name: "IX_MovBancosRubroFC_CuentaBancariaid",
                schema: "H2C",
                table: "MovBancosRubroFC",
                column: "CuentaBancariaid");

            migrationBuilder.CreateIndex(
                name: "IX_MovBancosRubroFC_FlujoCajaId",
                schema: "H2C",
                table: "MovBancosRubroFC",
                column: "FlujoCajaId");

            migrationBuilder.CreateIndex(
                name: "IX_PeriodosFC_FlujoCajaId",
                schema: "H2C",
                table: "PeriodosFC",
                column: "FlujoCajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Proyecciones_DocTributarioId",
                schema: "H2C",
                table: "Proyecciones",
                column: "DocTributarioId");

            migrationBuilder.CreateIndex(
                name: "IX_RubrosFC_FlujoCajaId",
                schema: "H2C",
                table: "RubrosFC",
                column: "FlujoCajaId");

            migrationBuilder.CreateIndex(
                name: "IX_VersionesFC_FlujoCajaId",
                schema: "H2C",
                table: "VersionesFC",
                column: "FlujoCajaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalculosFC",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "ChequesRubroFC",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "DetallesFC",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "DetallesFCEjecuta",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "DetallesInversiones",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "DetallesProyecciones",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "FCCuentasBancos",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "GlobalesFC",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "Inversiones",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "MovBancosRubroFC",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "PeriodosFC",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "Proyecciones",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "RubrosFC",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "VersionesFC",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "FlujosCaja",
                schema: "H2C");
        }
    }
}
