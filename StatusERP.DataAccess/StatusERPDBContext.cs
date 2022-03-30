using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;    
using StatusERP.Entities.AS.Tablas;
using StatusERP.Entities.CG.Tablas;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Entities.FA.Tablas;
using StatusERP.Entities.CC.Tablas;
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
        public DbSet<GlobalesCG> GlobalesCG  { get; set; }
        public DbSet<MayorAuditoria> MayorAuditoria { get; set; }
        public DbSet<MayorDet> MayorDet { get; set; }
        public DbSet<MayorEnc> MayorEnc { get; set; }
        public DbSet<PaqueteContable> PaquetesContables { get; set; }
        public DbSet<SaldoCuenta> SaldosCuentas { get; set; }
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
        public DbSet<DesBonEscalaBonificacion>  DesBonEscalaBonificacion { get; set; }
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



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Parentesco>()
                .HasIndex(p => p.Padre, "IxPadre");

            modelBuilder.Entity<PrivilegioUsuario>()
                .HasIndex(p => p.UsuarioId, "IxUsuarioId");
        }
    }
}