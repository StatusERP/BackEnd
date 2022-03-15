using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;    
using StatusERP.Entities.AS.Tablas;
using StatusERP.Entities.CG.Tablas;
using StatusERP.Entities.CI.Tablas;
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
        //public DbSet<Lote> Lotes { get; set; }
        //public DbSet<Articulo> Articulos { get; set; }
        //public DbSet<CategoriaArticulo> CategoriasArticulos { get; set; }
        //public DbSet<IngresoLote> IngresosLotes { get; set; }
        //public DbSet<ExistenciaLote> ExistenciaLotes { get; set; }
        //public DbSet<ClasificacionInv> ClasificacionesInv { get; set; }
        //public DbSet<ConsecutivoInv> ConsecutivosInv { get; set; }
        //public DbSet<ConsecutivoInvUsuario> ConsecutivosInvUsuarios { get; set; }
        //public DbSet<AjusteConfig> AjustesConfig { get; set; }
        //public DbSet<AjusteSubTipo> AjustesSubTipo { get; set; }
        public DbSet<PaqueteInv> PaquetesInv { get; set; }
        public DbSet<UsuarioAjusteInv> UsuarioAjusteInv { get; set; }
        public DbSet<ExistenciaBodega> ExistenciaBodega { get; set; }
        public DbSet<GlobalesCI>  GlobalesCI { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<AjusteSubTipo>()
                //.HasKey(p => new {p.AjusteConfig, p.Subtipo});

            //modelBuilder.Entity<Bodega>()
            //  .HasIndex(p => p.CodBodega, "IxBodegaId")
            //.IsUnique();

            //modelBuilder.Entity<CategoriaCliente>()
            //    .HasIndex(p => p.CodCategoriaCliente, "IxCategoriaClienteId")
            //    .IsUnique();

            //modelBuilder.Entity<CategoriaProveedor>()
            //    .HasIndex(p => p.CodCategoriaProveedor, "IxCategoriaProveedorId")
            //    .IsUnique();

            //modelBuilder.Entity<CentroCosto>()
            //  .HasIndex(p => p.CodCentroCosto, "IxCentroCostoId")
            //.IsUnique();

            //modelBuilder.Entity<CentroCuenta>()
            //   .HasKey(c => new { c.CentroCosto, c.CuentaContable });

            //modelBuilder.Entity<Cobrador>()
            //.HasIndex(p => p.CodCobrador, "IxCobradorId")
            //.IsUnique();


            //modelBuilder.Entity<CondicionPago>()
            //    .HasIndex(p => p.CodCondicionPago, "IxCondicionPagoId")
            //    .IsUnique();

            //modelBuilder.Entity<ConsecutivoGlobal>()
            //    .HasIndex(p => p.CodConsecutivoGlobal, "IxConsecutivoGlobalId")
            //    .IsUnique();

            //modelBuilder.Entity<ConsecutivoUsuario>()
            //    .HasIndex(p => p.CodConsecutivo, "IxConsecutivoUsuarioId")
            //    .IsUnique();

            //modelBuilder.Entity<CuentaContable>()
            //    .HasIndex(p => p.CodCuentaContable, "IxCuentaContableId")
            //    .IsUnique();

            //modelBuilder.Entity<CuadreCG>()
            //    .HasIndex(p => p.CodCuadreCG, "IxCuadreCGId")
            //    .IsUnique();

            //modelBuilder.Entity<DiarioEnc>()
            //    .HasIndex(p => p.Asiento, "IxAsientoId")
            //    .IsUnique();

            //modelBuilder.Entity<DocTributario>()
            //    .HasIndex(p => p.CodDocTributario, "IxDocTributarioId")
            //    .IsUnique();

            //modelBuilder.Entity<EntidadFinanciera>()
            //    .HasIndex(p => p.CodEntidadFinanciera, "IxEntidadFinancieraId")
            //    .IsUnique();

            //modelBuilder.Entity<Impuesto>()
            //.HasIndex(p => p.CodImpuesto, "IxImpuestoId")
            //.IsUnique();

            //modelBuilder.Entity<PaqueteContable>()
            //.HasIndex(p => p.CodPaquete, "IxPaqueteId")
            //.IsUnique();

            //modelBuilder.Entity<Pais>()
            //  .HasOne(p => p.CodPais)
            //.WithMany <DivGeografica1>
            //.HasForeignKey(p => p.Pais);

            // modelBuilder.Entity<DivGeografica1>()
            //    .HasAlternateKey(p => p.CodDivGeografica1)

            //modelBuilder.Entity<MayorEnc>()
            //    .HasIndex(p => p.Asiento, "IxAsientoId")
            //    .IsUnique();

            //modelBuilder.Entity<Moneda>()
            //    .HasIndex(p => p.CodMoneda, "IxMonedaId")
            //    .IsUnique();

            //modelBuilder.Entity<NivelPrecio>()
            //    .HasIndex(p => p.CodNivelPrecio, "IxNivelPrecioId")
            //    .IsUnique();

            //modelBuilder.Entity<Pais>()
            //    .HasIndex(p => p.CodPais, "IxPaisId")
            //    .IsUnique();

            //modelBuilder.Entity<PaqueteContable>()
            //    .HasIndex(p => p.CodPaquete, "IxPaqueteId")
            //    .IsUnique();

            //modelBuilder.Entity<Ruta>()
            //    .HasIndex(p => p.CodRuta, "IxRutaId")
            //    .IsUnique();

            //modelBuilder.Entity<Sucursal>()
            // .HasAlternateKey(p => p.CodSucursal)
            //.HasName("AKCodSucursal");

            //modelBuilder.Entity<DivGeografica1>()
            //   .HasKey(c => new { c.Pais, c.CodDivGeografica1 });

            //modelBuilder.Entity<TipoCambio>()
            //    .HasIndex(p => p.CodTipoCambio, "IxTipoCambioId")
            //    .IsUnique();

            //modelBuilder.Entity<UnidadMedida>()
            //    .HasIndex(p => p.CodUnidadMedida, "IxUnidadMedidaId")
            //    .IsUnique();

            //modelBuilder.Entity<Vendedor>()
            //.HasIndex(p => p.CodVendedor, "IxVendedorId")
            //.IsUnique();

            //modelBuilder.Entity<Zona>()
            //    .HasIndex(p => p.CodZona, "IxZonaId")
            //    .IsUnique();
        }
    }
}