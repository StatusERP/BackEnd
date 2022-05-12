using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;    
using StatusERP.Entities.AS.Tablas;
using StatusERP.Entities.CG.Tablas;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Entities.FA.Tablas;
using StatusERP.Entities.CC.Tablas;
using StatusERP.Entities.CP.Tablas;
using StatusERP.Entities.CB.Tablas;
using StatusERP.Entities.FC.Tablas;
using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.DataAccess
{
    public class StatusERPDBContext : IdentityDbContext<StatusERPUserIdentity>
    {
        public StatusERPDBContext()
        {

        }

        public StatusERPDBContext(DbContextOptions<StatusERPDBContext> options) : base(options)
        {

        }
        // Para tablas de ERPADMIN
        public DbSet<Accion> Accion { get; set; }
        public DbSet<Conjunto> Conjunto { get; set; }
        public DbSet<GrupoUsuario> GrupoUsuario { get; set; }
        public DbSet<Membresia> Membresia { get; set; }
        public DbSet<Parentesco> Parentesco { get; set; }
        public DbSet<PrivilegioUsuario> PrivilegioUsuario { get; set; }
        public DbSet<BitacoraProceso> BitacoraProceso { get; set; }
        public DbSet<Favoritos> Favoritos { get; set; }
        public DbSet<Locks> Locks { get; set; }
        public DbSet<ModuloInstalado> ModuloInstalado { get; set; }

        // Para tablas de AS
        public DbSet<Bodega> Bodegas { get; set; }
        public DbSet<CategoriaCliente> CategoriasCliente { get; set; }
        public DbSet<CategoriaProveedor> CategoriasProveedor { get; set; }
        public DbSet<CentroCosto> CentrosCosto { get; set; }
        public DbSet<Cobrador> Cobradores { get; set; }
        public DbSet<CondicionPago> CondicionesPago { get; set; }
        public DbSet<ConsecutivoGlobal> ConsecutivosGlobales { get; set; }
        public DbSet<ConsecutivoUsuario> ConsecutivoUsuario { get; set; }
        public DbSet<DivGeografica1> DivGeograficas1 { get; set; }
        public DbSet<DivGeografica2> DivGeograficas2 { get; set; }
        public DbSet<DocTributario> DocTributarios { get; set; }
        public DbSet<EntidadFinanciera> EntidadesFinancieras { get; set; }
        public DbSet<GlobalesAS> GlobalesAS { get; set; }
        public DbSet<Impuesto> Impuestos { get; set; }
        public DbSet<Moneda> Monedas { get; set; }
        public DbSet<Localizacion> Localizaciones { get; set; }
        public DbSet<NivelPrecio> NivelesPrecio { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<PeriodoContable> PeriodosContables { get; set; }
        public DbSet<Ruta> Rutas { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<TipoCambio> TiposCambio { get; set; }
        public DbSet<UnidadMedida> UnidadesMedida { get; set; }
        public DbSet<UsuarioBodega> UsuarioBodega { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Zona> Zonas { get; set; }


        // Para tablas de CG
        public DbSet<CentroCuenta> CentroCuenta { get; set; }
        public DbSet<CuadreAuxiliar> CuadresAuxiliar { get; set; }
        public DbSet<CuadreCG> CuadresCG { get; set; }
        public DbSet<CuadreConta> CuadresConta { get; set; }
        public DbSet<CuentaContable> CuentasContables { get; set; }
        public DbSet<DiarioDet> DiaroDet { get; set; }
        public DbSet<DiarioEnc> DiarioEnc { get; set; }
        public DbSet<Diferido> Diferidos { get; set; }
        public DbSet<GlobalesCG> GlobalesCG { get; set; }
        public DbSet<MayorAuditoria> MayorAuditoria { get; set; }
        public DbSet<MayorDet> MayorDet { get; set; }
        public DbSet<MayorEnc> MayorEnc { get; set; }
        public DbSet<PaqueteContable> PaquetesContables { get; set; }
        public DbSet<SaldoCuenta> SaldosCuentas { get; set; }
        public DbSet<SeccionCuenta> SeccionesCuentas { get; set; }
        public DbSet<TipoPartida> TiposPartidas { get; set; }
        public DbSet<UsuarioPaquete> UsuarioPaquete { get; set; }


        // Para tablas de CI
        public DbSet<AjusteConfig> AjustesConfig { get; set; }
        public DbSet<AjusteSubTipo> AjustesSubTipo { get; set; }
        public DbSet<AjusteSubSubTipo> AjustesSubSubTipo { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<CategoriaArticulo> CategoriasArticulos { get; set; }
        public DbSet<ClasificacionInv> ClasificacionesInv { get; set; }
        public DbSet<ConsecutivoInv> ConsecutivosInv { get; set; }
        public DbSet<ConsecutivoInvUsuario> ConsecutivosInvUsuarios { get; set; }
        public DbSet<DocumentoInvDet> DocumentosInvDet { get; set; }
        public DbSet<DocumentoInvEnc> DocumentosInvEnc { get; set; }
        public DbSet<ExistenciaBodega> ExistenciaBodega { get; set; }
        public DbSet<ExistenciaLote> ExistenciaLotes { get; set; }
        public DbSet<GlobalesCI> GlobalesCI { get; set; }
        public DbSet<IngresoLote> IngresosLotes { get; set; }
        public DbSet<Lote> Lotes { get; set; }
        public DbSet<MovInventarioDet> MovsInventarioDet { get; set; }
        public DbSet<MovInventarioEnc> MovsInventarioEnc { get; set; }
        public DbSet<PaqueteInv> PaquetesInv { get; set; }
        public DbSet<UsuarioAjusteInv> UsuarioAjusteInv { get; set; }
        public DbSet<TipoPago> TiposPago { get; set; }

        // Para tablas de FA
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<TipoFactura> TiposFactura { get; set; }
        public DbSet<ConsecutivoFA> ConsecutivosFA { get; set; }
        public DbSet<ArticuloPrecio> ArticuloPrecios { get; set; }
        public DbSet<VersionNivelPrecio> VersionesNivelPrecio { get; set; }
        public DbSet<ConsecuFAUsuario> ConsecuFAUsuarios { get; set; }
        public DbSet<GlobalesFA> GlobalesFA { get; set; }
        public DbSet<PaqueteDescuento> PaquetesDescuento { get; set; }
        public DbSet<ReglaDescuento> ReglasDescuento { get; set; }
        public DbSet<EscalaBonif> EscalasBonif { get; set; }
        public DbSet<BonifArtXCli> BonifsArtXCli { get; set; }
        public DbSet<BonifClasXCli> BonifsClasXCli { get; set; }
        public DbSet<DesBonEscalaBonificacion> DesBonEscalaBonificacion { get; set; }
        public DbSet<EscalaDcto> EscalasDcto { get; set; }
        public DbSet<PedidoEnc> PedidoEncs { get; set; }
        public DbSet<PedidoDet> PedidoDets { get; set; }
        public DbSet<FacturaDet> FacturaDets { get; set; }
        public DbSet<FacturaEnc> FacturaEncs { get; set; }


        // Para tablas de CC
        public DbSet<RetencionesDocCC> RetencionesDocCC { get; set; }
        public DbSet<SaldoCliente> SaldosClientes { get; set; }
        public DbSet<SubTipoDocCC> SubTiposDocCC { get; set; }
        public DbSet<ClienteRetencion> ClientesRetenciones { get; set; }
        public DbSet<AuxiliarCC> AuxiliarCC { get; set; }
        public DbSet<DocumentosCC> DocumentosCC { get; set; }
        public DbSet<GlobalesCC> GlobalesCC { get; set; }


        // Para tablas de CP
        public DbSet<SubTipoDocCP> SubTipoDocCP { get; set; }
        public DbSet<HistoricoDifCambiarioCP> HistoricoDifCambiarioCP { get; set; }
        public DbSet<AuxiliarCP> AuxiliarCP { get; set; }
        public DbSet<Quedan> Quedans { get; set; }
        public DbSet<DocumentoCP> DocumentosCP { get; set; }
        public DbSet<GlobalesCP> GlobalesCP { get; set; }
        public DbSet<DetalleRetencion> DetalleRetencion { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<ProveedorEntidad> ProveedorEntidades { get; set; }


        // Para tablas de CB
        public DbSet<CuentaBancaria> CuentasBancarias { get; set; }   
        public DbSet<TipoCuentaBanco>   TiposCuentasBancos { get; set; }
        public DbSet<SubTipoDocCB> SubTiposDocCB { get; set; }
        public DbSet<AsientoCheque> AsientosCheques { get; set; }
        public DbSet<GlobalesCB> GlobalesCB { get; set; }
        public DbSet<ConciliacionBancaria> ConciliacionesBancarias { get; set; }
        public DbSet<Cheque> Cheques { get; set; }
        public DbSet<TransferenciaCB> TransferenciasCB { get; set;}
        public DbSet<DetTransCB> DetTransCB { get; set; }
        public DbSet<MovReportados> MovReportados { get; set; }
        public DbSet<MovProcesados> MovProcesados { get; set; }
        public DbSet<MovBancos> MovBancos { get; set; }

        // Para Tablas de FC
        public DbSet<CalculoFC> CalculosFC { get; set; }
        public DbSet<ChequeRubroFC> ChequesRubroFC { get; set; }
        public DbSet<DetalleFC> DetallesFC { get; set; }
        public DbSet<DetalleFCEjecuta> DetallesFCEjecuta { get; set; }
        public DbSet<DetalleInversion> DetallesInversiones { get; set; }
        public DbSet<DetalleProyeccion> DetallesProyecciones { get; set; }
        public DbSet<FCCuentaBanco> FCCuentasBancos { get; set; }
        public DbSet<FlujoCaja> FlujosCaja { get; set; }
        public DbSet<GlobalesFC> GlobalesFC { get; set; }
        public DbSet<Inversion> Inversiones { get; set; }
        public DbSet<MovBancosRubroFC> MovBancosRubroFC { get; set; }
        public DbSet<PeriodoFC> PeriodosFC { get; set; }
        public DbSet<Proyeccion> Proyecciones { get; set; }
        public DbSet<RubroFC> RubrosFC { get; set; }
        public DbSet<VersionFC> VersionesFC { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Parentesco>()
                .HasIndex(p => p.Padre, "IxPadre");

            modelBuilder.Entity<PrivilegioUsuario>()
                .HasIndex(p => p.UsuarioId, "IxUsuarioId");

            modelBuilder.Entity<Articulo>()
                .HasIndex(p => new { p.CodArticulo }).IsUnique();


            //CI - CategoriaArticulo

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCInventario)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaInventarioId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCVentasLoc)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaVentasLocId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCVentasExp)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaVentasExpId);

            modelBuilder.Entity<CategoriaArticulo>()
               .HasOne(x => x.CCCompraLoc)
               .WithMany()
               .HasForeignKey(x => x.CtrCtaCompraLocId);

            modelBuilder.Entity<CategoriaArticulo>()
               .HasOne(x => x.CCCompraImp)
               .WithMany()
               .HasForeignKey(x => x.CtrCtaCompraImpId);

            modelBuilder.Entity<CategoriaArticulo>()
               .HasOne(x => x.CCDescVentaLoc)
               .WithMany()
               .HasForeignKey(x => x.CtrCtaDescVentaLocId);

            modelBuilder.Entity<CategoriaArticulo>()
               .HasOne(x => x.CCDescVentaExp)
               .WithMany()
               .HasForeignKey(x => x.CtrCtaDescVentaExpId);

            modelBuilder.Entity<CategoriaArticulo>()
               .HasOne(x => x.CCCostVentaLoc)
               .WithMany()
               .HasForeignKey(x => x.CtrCtaCostVentaLocId);

            modelBuilder.Entity<CategoriaArticulo>()
               .HasOne(x => x.CCCostVentaLoc)
               .WithMany()
               .HasForeignKey(x => x.CtrCtaCostVentaLocId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCCostVentaExp)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaCostVentaExpId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCComsVentaLoc)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaComsVentaLocId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCComsVentaExp)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaComsVentaExpId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCComsCobroLoc)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaComsCobroLocId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCComsCobroExp)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaComsCobroExpId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCDescLineaLoc)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaDescLineaLocId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCDescLineaExp)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaDescLineaExpId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCCostoDescLoc)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaCostDescLocId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCCostDescExp)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaCostDescExpId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCSobrInventFis)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaSobrInventFisId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCFaltInventFis)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaFaltInventFisId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCVariaCosto)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaVariaCostoId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCVencimiento)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaVencimientoId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCSobranteRemis)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaSobranteRemisId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCFaltanteRemis)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaFaltanteRemisId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCInvRemitido)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaInvRemitidoId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCMatProceso)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaMatProcesoId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCConsNormal)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaConsNormalId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCConsRetrabajo)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaConsRetrabajoId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCConsGasto)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaConsGastoId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCConsDesperdic)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaConsDesperdicId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCDescBonifLoc)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaDescBonifLocId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCDescBonifExp)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaDescBonifExpId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCDevVentasLoc)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaDevVentasLocId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCDevVentasExp)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaDevVentasExpId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCRetAsum)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaRetAsumId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCAju)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaAjuId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCAjuCMV)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaAjuCMVId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCCPGar)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaCPGarId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCPuGar)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaPuGarId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCIngDevoluc)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaIngDevolucId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCPerdDevoluc)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaPerdDevolucId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCMatAplicados)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaMatAplicadosId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCVentasExenLoc)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaVentasExenLocId);

            modelBuilder.Entity<CategoriaArticulo>()
                .HasOne(x => x.CCVentasExenExp)
                .WithMany()
                .HasForeignKey(x => x.CtrCtaVentasExenExpId);

            //CI - TipoPago

            modelBuilder.Entity<TipoPago>()
                .HasIndex(p => p.CodTipoPago , "IxCodTipoPago");

            //CI - Lotes

            //modelBuilder.Entity<Lote>()
            //    .HasOne(x => x.ArtEnLote)
            //    .WithMany()
            //    .HasForeignKey(y => y.Id);

        }
    }
}