using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusERP.DataAccess.Migrations
{
    public partial class TablasCB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AsientosCheques",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Consecutivo = table.Column<int>(type: "int", nullable: false),
                    CtrContable = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CtaContable = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    TipoAsiento = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Debito = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    Credito = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsientosCheques", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CuentasBancarias",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumCuentaBancaria = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    EntidadFinancieraId = table.Column<int>(type: "int", nullable: false),
                    Moneda = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false),
                    Telefono1 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Telefono2 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Contacto = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Formato = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    FechaUltMov = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Saldo = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoBancos = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PosicionDeCaja = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoAnterior = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoCambioLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoCambioDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Activa = table.Column<bool>(type: "bit", nullable: false),
                    UltimoDeposito = table.Column<decimal>(type: "decimal(28,0)", nullable: false),
                    UltimaTEFCR = table.Column<decimal>(type: "decimal(28,0)", nullable: false),
                    LimiteSobregiro = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CtrContable = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaContable = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCierreDeb = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCierreDeb = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrCierreCred = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaCierreCred = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    UltimaNotaCR = table.Column<decimal>(type: "decimal(28,0)", nullable: false),
                    UltimoCheque = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    UltimoOtroCR = table.Column<decimal>(type: "decimal(28,0)", nullable: false),
                    UltimaTEFDB = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    UltimaNotaDB = table.Column<decimal>(type: "decimal(28,0)", nullable: false),
                    UltimoOtroDB = table.Column<decimal>(type: "decimal(28,0)", nullable: false),
                    UltimaConcil = table.Column<int>(type: "int", nullable: true),
                    ModoConciliar = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    IdiomaMonLetras = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    TipoCredAjuste = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    SubTipoCredAjust = table.Column<short>(type: "smallint", nullable: true),
                    TipoDebAjuste = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    SubTipoDebAjust = table.Column<short>(type: "smallint", nullable: true),
                    PermiteSobregiro = table.Column<bool>(type: "bit", nullable: false),
                    CtaAjusteCred = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    FechaHoraCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CtrAjusteDeb = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrGastoTransf = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaAjusteDeb = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaGastoTransf = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrLiquidarCred = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaLiquidarCred = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrLiquidarDeb = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaLiquidarDeb = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrAjusteCred = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    FchHoraModific = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioModific = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    PermiteTransfIC = table.Column<bool>(type: "bit", nullable: false),
                    CtaTransfIC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtrTransfIC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Rubro1CtaBanco = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro2CtaBanco = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro3CtaBanco = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro4CtaBanco = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro5CtaBanco = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro6CtaBanco = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro7CtaBanco = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro8CtaBanco = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro9CtaBanco = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Rubro10CtaBanco = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ConseCheque = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ConseTEF = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TipoCuenta = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    CtrDocGP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CtaDocGP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SaldoTrans = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoTransLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    SaldoTransDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    PermiteDocGP = table.Column<bool>(type: "bit", nullable: false),
                    ParticipaFlujoCaja = table.Column<bool>(type: "bit", nullable: false),
                    CtaElectronica = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentasBancarias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CuentasBancarias_EntidadesFinancieras_EntidadFinancieraId",
                        column: x => x.EntidadFinancieraId,
                        principalSchema: "H2C",
                        principalTable: "EntidadesFinancieras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GlobalesCB",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PausarEnCheques = table.Column<bool>(type: "bit", nullable: false),
                    FecAsientoCheq = table.Column<bool>(type: "bit", nullable: false),
                    ImpCheqPantalla = table.Column<bool>(type: "bit", nullable: false),
                    TipoAsiento = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Paquete = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    AsientoDep = table.Column<bool>(type: "bit", nullable: false),
                    AsientoNCR = table.Column<bool>(type: "bit", nullable: false),
                    AsientoOCR = table.Column<bool>(type: "bit", nullable: false),
                    AsientoCHQ = table.Column<bool>(type: "bit", nullable: false),
                    AsientoNDB = table.Column<bool>(type: "bit", nullable: false),
                    AsientoODB = table.Column<bool>(type: "bit", nullable: false),
                    AsientoTEFDB = table.Column<bool>(type: "bit", nullable: false),
                    AsientoTEFCR = table.Column<bool>(type: "bit", nullable: false),
                    FechaUltDifCamb = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcilNoEntregado = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    DefDocEntregado = table.Column<bool>(type: "bit", nullable: false),
                    IntegracionConta = table.Column<bool>(type: "bit", nullable: false),
                    ModAplicAsiento = table.Column<short>(type: "smallint", nullable: false),
                    CopiarNotasEnAsnt = table.Column<bool>(type: "bit", nullable: false),
                    MostrarChqSug = table.Column<bool>(type: "bit", nullable: false),
                    ImprimirMontoMon = table.Column<bool>(type: "bit", nullable: false),
                    CantLineasAsnt = table.Column<int>(type: "int", nullable: false),
                    ValidarDocAsnt = table.Column<bool>(type: "bit", nullable: false),
                    VerCtasInactivas = table.Column<bool>(type: "bit", nullable: false),
                    UsaRubrosCtaBanco = table.Column<bool>(type: "bit", nullable: false),
                    Rubro1CtaBanco = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Rubro2CtaBanco = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Rubro3CtaBanco = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Rubro4CtaBanco = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Rubro5CtaBanco = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Rubro6CtaBanco = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Rubro7CtaBanco = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Rubro8CtaBanco = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Rubro9CtaBanco = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Rubro10CtaBanco = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ConseLote = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalesCB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubTiposDocCB",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    SubTipo = table.Column<short>(type: "smallint", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CuentaContable = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CentroCosto = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TipoAsiento = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Paquete = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    TipoServicio = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    DocumentoGlobal = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RubroCF = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    RubroPadre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FlujoCaja = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NaturalezaCF = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTiposDocCB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposCuentasBancos",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodTipoCuentaBanco = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposCuentasBancos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cheques",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChequeId = table.Column<int>(type: "int", nullable: false),
                    CuentaBancariaId = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    SubTipo = table.Column<short>(type: "smallint", nullable: true),
                    PagaderoA = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Referencia = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    FechaHoraModific = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioModific = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    FechaHoraUltAplic = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Recurrente = table.Column<bool>(type: "bit", nullable: false),
                    Concepto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocTributarioId = table.Column<int>(type: "int", nullable: true),
                    Seleccionado = table.Column<bool>(type: "bit", nullable: false),
                    FechaHoraCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioUltAplic = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    ResponsableSolic = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Aprobado = table.Column<bool>(type: "bit", nullable: false),
                    OrigenSolicitud = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    DocumentoGlobal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MetodoPago = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cheques", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cheques_CuentasBancarias_CuentaBancariaId",
                        column: x => x.CuentaBancariaId,
                        principalSchema: "H2C",
                        principalTable: "CuentasBancarias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cheques_DocTributarios_DocTributarioId",
                        column: x => x.DocTributarioId,
                        principalSchema: "H2C",
                        principalTable: "DocTributarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ConciliacionesBancarias",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CuentaBancariaId = table.Column<int>(type: "int", nullable: false),
                    Conciliacion = table.Column<int>(type: "int", nullable: false),
                    FechaInicial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SaldoLibros = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    SaldoBancos = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    CreditosTransito = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    DebitosTransito = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    CreditosConcil = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    DebitosConcil = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    CreditosSinDinf = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    DebitosSinDif = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    CreditosConAjust = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    DebitosConAjust = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    CreditosAjustes = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    DebitosAjustes = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    CreditosLiquidar = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    DebitosLiquidad = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    CreditosAclarar = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    DebitosAclarar = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    CreditosAclaraEF = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    DebitosAclaraEF = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    CreditosAclaraCB = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    DebitosAclaraCB = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaHoraCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    FechaHoraModific = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioModific = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    FechaHoraAprobacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioAprobacion = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConciliacionesBancarias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConciliacionesBancarias_CuentasBancarias_CuentaBancariaId",
                        column: x => x.CuentaBancariaId,
                        principalSchema: "H2C",
                        principalTable: "CuentasBancarias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetTransCB",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Consecutivo = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CuentaOrigenId = table.Column<int>(type: "int", nullable: false),
                    CuentaBancariaId = table.Column<int>(type: "int", nullable: false),
                    TipoOrigen = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    NumeroOrigen = table.Column<decimal>(type: "decimal(28,0)", nullable: false),
                    CuentaDestino = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipoDestino = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    NumeroDestino = table.Column<decimal>(type: "decimal(28,0)", nullable: false),
                    MontoComision = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    TipoCambio = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    MontoOrigen = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    MontoDestino = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    CompaniaDestino = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TipoMov = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Beneficiario = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DocTributarioId = table.Column<int>(type: "int", nullable: true),
                    Concepto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EntidadFinacieraId = table.Column<int>(type: "int", nullable: true),
                    EntidadFinancieraId = table.Column<int>(type: "int", nullable: false),
                    MonedaId = table.Column<int>(type: "int", nullable: true),
                    Rubro1DetTrans = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Rubro2DetTrans = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Rubro3DetTrans = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Rubro4DetTrans = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Rubro5DetTrans = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Rubro6DetTrans = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Rubro7DetTrans = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Rubro8DetTrans = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Rubro9DetTrans = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Rubro10DetTrans = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CtrCierreTercerosId = table.Column<int>(type: "int", nullable: true),
                    CentroCostoId = table.Column<int>(type: "int", nullable: false),
                    CtaCierreTerceros = table.Column<int>(type: "int", nullable: true),
                    CuentaContableId = table.Column<int>(type: "int", nullable: false),
                    MetodoPago = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetTransCB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetTransCB_CentrosCosto_CentroCostoId",
                        column: x => x.CentroCostoId,
                        principalSchema: "H2C",
                        principalTable: "CentrosCosto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetTransCB_CuentaContable_CuentaContableId",
                        column: x => x.CuentaContableId,
                        principalSchema: "H2C",
                        principalTable: "CuentaContable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetTransCB_CuentasBancarias_CuentaBancariaId",
                        column: x => x.CuentaBancariaId,
                        principalSchema: "H2C",
                        principalTable: "CuentasBancarias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetTransCB_DocTributarios_DocTributarioId",
                        column: x => x.DocTributarioId,
                        principalSchema: "H2C",
                        principalTable: "DocTributarios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetTransCB_EntidadesFinancieras_EntidadFinancieraId",
                        column: x => x.EntidadFinancieraId,
                        principalSchema: "H2C",
                        principalTable: "EntidadesFinancieras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DetTransCB_Monedas_MonedaId",
                        column: x => x.MonedaId,
                        principalSchema: "H2C",
                        principalTable: "Monedas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MovProcesados",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CuentaBancariaId = table.Column<int>(type: "int", nullable: false),
                    TipoDocumento = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Numero = table.Column<decimal>(type: "decimal(28,0)", nullable: false),
                    ArchivoTXT = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FechaGenerado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioProcesa = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    FechaProcesa = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovProcesados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovProcesados_CuentasBancarias_CuentaBancariaId",
                        column: x => x.CuentaBancariaId,
                        principalSchema: "H2C",
                        principalTable: "CuentasBancarias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransferenciasCB",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CuentaOrigenId = table.Column<int>(type: "int", nullable: false),
                    CuentaBancariaId = table.Column<int>(type: "int", nullable: false),
                    TipoOrigen = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    NumeroOrigen = table.Column<decimal>(type: "decimal(28,0)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    MontoComision = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    MontoOrigen = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Asiento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    FechaHoraCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    FechaHoraModific = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioModific = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    FechaAplicacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Rubro1Trans = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Rubro2Trans = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Rubro3Trans = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Rubro4Trans = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Rubro5Trans = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Rubro6Trans = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Rubro7Trans = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Rubro8Trans = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Rubro9Trans = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Rubro10Trans = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DocumentoFiscal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DocumentoGlobal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MetodoPago = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferenciasCB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransferenciasCB_CuentasBancarias_CuentaBancariaId",
                        column: x => x.CuentaBancariaId,
                        principalSchema: "H2C",
                        principalTable: "CuentasBancarias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovBancos",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CuentaBancoId = table.Column<int>(type: "int", nullable: false),
                    CuentaBancariaId = table.Column<int>(type: "int", nullable: false),
                    TipoDocumento = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Numero = table.Column<decimal>(type: "decimal(28,0)", nullable: false),
                    SubTipo = table.Column<short>(type: "smallint", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PagaderoA = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Referencia = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    ConcilAclaracionId = table.Column<int>(type: "int", nullable: true),
                    ProveedorId = table.Column<int>(type: "int", nullable: true),
                    DocTributarioId = table.Column<int>(type: "int", nullable: true),
                    Detalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Confirmado = table.Column<bool>(type: "bit", nullable: false),
                    Origen = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Asiento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Anulado = table.Column<bool>(type: "bit", nullable: false),
                    FechaHoraCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    MontoAnulado = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    ConciliacionId = table.Column<int>(type: "int", nullable: true),
                    ConciliacionBancariaId = table.Column<int>(type: "int", nullable: false),
                    Impreso = table.Column<bool>(type: "bit", nullable: false),
                    DocReportado = table.Column<int>(type: "int", nullable: true),
                    MontoReportado = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    ClaseDif = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    AclaradaDif = table.Column<bool>(type: "bit", nullable: false),
                    DocAjuste = table.Column<int>(type: "int", nullable: true),
                    TipoDocAjuste = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    NumeroDocAjuste = table.Column<decimal>(type: "decimal(28,0)", nullable: true),
                    ClaseDocumento = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    ModoRegistro = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Liquidado = table.Column<bool>(type: "bit", nullable: false),
                    FechaHoraModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioModific = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    TipoCambioLocal = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    TipoCambioDolar = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    FechaHoraAnulado = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioAnulado = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    ReferenciaAnulado = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Aprobado = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioAprobacion = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    FechaAprobacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TipoAsiento = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    PaqueteId = table.Column<int>(type: "int", nullable: true),
                    PaqueteContableId = table.Column<int>(type: "int", nullable: false),
                    DependienteGP = table.Column<bool>(type: "bit", nullable: false),
                    DocumentoFiscal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FechaContable = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CodImpuesto1 = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Impuesto1 = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    Imp1NoDes = table.Column<decimal>(type: "decimal(28,8)", nullable: true),
                    DocumentoGlobal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TipoCF = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    MetodoPago = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovBancos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovBancos_ConciliacionesBancarias_ConcilAclaracionId",
                        column: x => x.ConcilAclaracionId,
                        principalSchema: "H2C",
                        principalTable: "ConciliacionesBancarias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MovBancos_ConciliacionesBancarias_ConciliacionBancariaId",
                        column: x => x.ConciliacionBancariaId,
                        principalSchema: "H2C",
                        principalTable: "ConciliacionesBancarias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovBancos_CuentasBancarias_CuentaBancariaId",
                        column: x => x.CuentaBancariaId,
                        principalSchema: "H2C",
                        principalTable: "CuentasBancarias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_MovBancos_DocTributarios_DocTributarioId",
                        column: x => x.DocTributarioId,
                        principalSchema: "H2C",
                        principalTable: "DocTributarios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MovBancos_PaquetesContables_PaqueteContableId",
                        column: x => x.PaqueteContableId,
                        principalSchema: "H2C",
                        principalTable: "PaquetesContables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovBancos_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalSchema: "H2C",
                        principalTable: "Proveedores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MovReportados",
                schema: "H2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocReportado = table.Column<int>(type: "int", nullable: false),
                    CuentaBancariaId = table.Column<int>(type: "int", nullable: true),
                    TipoDocumento = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Numero = table.Column<decimal>(type: "decimal(28,0)", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(28,8)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    ModoRegistro = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Compensado = table.Column<bool>(type: "bit", nullable: false),
                    ConciliacionId = table.Column<int>(type: "int", nullable: true),
                    ConciliacionBancariaId = table.Column<int>(type: "int", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaHoraCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaHoraModific = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocCompensac = table.Column<int>(type: "int", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    UsuarioModific = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    TipoCF = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovReportados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovReportados_ConciliacionesBancarias_ConciliacionBancariaId",
                        column: x => x.ConciliacionBancariaId,
                        principalSchema: "H2C",
                        principalTable: "ConciliacionesBancarias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovReportados_CuentasBancarias_CuentaBancariaId",
                        column: x => x.CuentaBancariaId,
                        principalSchema: "H2C",
                        principalTable: "CuentasBancarias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cheques_CuentaBancariaId",
                schema: "H2C",
                table: "Cheques",
                column: "CuentaBancariaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cheques_DocTributarioId",
                schema: "H2C",
                table: "Cheques",
                column: "DocTributarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ConciliacionesBancarias_CuentaBancariaId",
                schema: "H2C",
                table: "ConciliacionesBancarias",
                column: "CuentaBancariaId");

            migrationBuilder.CreateIndex(
                name: "IX_CuentasBancarias_EntidadFinancieraId",
                schema: "H2C",
                table: "CuentasBancarias",
                column: "EntidadFinancieraId");

            migrationBuilder.CreateIndex(
                name: "IX_DetTransCB_CentroCostoId",
                schema: "H2C",
                table: "DetTransCB",
                column: "CentroCostoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetTransCB_CuentaBancariaId",
                schema: "H2C",
                table: "DetTransCB",
                column: "CuentaBancariaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetTransCB_CuentaContableId",
                schema: "H2C",
                table: "DetTransCB",
                column: "CuentaContableId");

            migrationBuilder.CreateIndex(
                name: "IX_DetTransCB_DocTributarioId",
                schema: "H2C",
                table: "DetTransCB",
                column: "DocTributarioId");

            migrationBuilder.CreateIndex(
                name: "IX_DetTransCB_EntidadFinancieraId",
                schema: "H2C",
                table: "DetTransCB",
                column: "EntidadFinancieraId");

            migrationBuilder.CreateIndex(
                name: "IX_DetTransCB_MonedaId",
                schema: "H2C",
                table: "DetTransCB",
                column: "MonedaId");

            migrationBuilder.CreateIndex(
                name: "IX_MovBancos_ConcilAclaracionId",
                schema: "H2C",
                table: "MovBancos",
                column: "ConcilAclaracionId");

            migrationBuilder.CreateIndex(
                name: "IX_MovBancos_ConciliacionBancariaId",
                schema: "H2C",
                table: "MovBancos",
                column: "ConciliacionBancariaId");

            migrationBuilder.CreateIndex(
                name: "IX_MovBancos_CuentaBancariaId",
                schema: "H2C",
                table: "MovBancos",
                column: "CuentaBancariaId");

            migrationBuilder.CreateIndex(
                name: "IX_MovBancos_DocTributarioId",
                schema: "H2C",
                table: "MovBancos",
                column: "DocTributarioId");

            migrationBuilder.CreateIndex(
                name: "IX_MovBancos_PaqueteContableId",
                schema: "H2C",
                table: "MovBancos",
                column: "PaqueteContableId");

            migrationBuilder.CreateIndex(
                name: "IX_MovBancos_ProveedorId",
                schema: "H2C",
                table: "MovBancos",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_MovProcesados_CuentaBancariaId",
                schema: "H2C",
                table: "MovProcesados",
                column: "CuentaBancariaId");

            migrationBuilder.CreateIndex(
                name: "IX_MovReportados_ConciliacionBancariaId",
                schema: "H2C",
                table: "MovReportados",
                column: "ConciliacionBancariaId");

            migrationBuilder.CreateIndex(
                name: "IX_MovReportados_CuentaBancariaId",
                schema: "H2C",
                table: "MovReportados",
                column: "CuentaBancariaId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferenciasCB_CuentaBancariaId",
                schema: "H2C",
                table: "TransferenciasCB",
                column: "CuentaBancariaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsientosCheques",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "Cheques",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "DetTransCB",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "GlobalesCB",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "MovBancos",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "MovProcesados",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "MovReportados",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "SubTiposDocCB",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "TiposCuentasBancos",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "TransferenciasCB",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "ConciliacionesBancarias",
                schema: "H2C");

            migrationBuilder.DropTable(
                name: "CuentasBancarias",
                schema: "H2C");
        }
    }
}
