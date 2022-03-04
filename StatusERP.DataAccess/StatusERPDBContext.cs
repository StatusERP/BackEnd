﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;    
using StatusERP.Entities.AS.Tablas;
using StatusERP.Entities.CG.Tablas;
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


        // Para tablas de AS
        public DbSet<Vendedor> Vendedores { get; set; }
      
        public DbSet<Bodega> Bodegas { get; set; }

        public DbSet<Cobrador> Cobradores { get; set; }

        public DbSet<Sucursal> Sucursales { get; set; }

        public DbSet<Pais> Paises { get; set; }

        public DbSet<DivGeografica1> DivGeograficas1 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Bodega>()
                .HasIndex(p => p.CodBodega, "IxBodegaId")
                .IsUnique();

            //modelBuilder.Entity<CategoriaCliente>()
            //    .HasIndex(p => p.CodCategoriaCliente, "IxCategoriaClienteId")
            //    .IsUnique();

            //modelBuilder.Entity<CategoriaProveedor>()
            //    .HasIndex(p => p.CodCategoriaProveedor, "IxCategoriaProveedorId")
            //    .IsUnique();

            modelBuilder.Entity<CentroCosto>()
                .HasIndex(p => p.CodCentroCosto, "IxCentroCostoId")
                .IsUnique();


            //modelBuilder.Entity<CentroCuenta>()
            //   .HasKey(c => new { c.CentroCosto, c.CuentaContable });

            modelBuilder.Entity<Cobrador>()
                .HasIndex(p => p.CodCobrador, "IxCobradorId")
                .IsUnique();
        

            //modelBuilder.Entity<Cobrador>().ToTable(name: "TablaCobradores", schema: "PRUEBA");

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

            modelBuilder.Entity<Impuesto>()
                .HasIndex(p => p.CodImpuesto, "IxImpuestoId")
                .IsUnique();

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

            modelBuilder.Entity<Sucursal>()
                .HasAlternateKey(p => p.CodSucursal)
                .HasName("AKCodSucursal");

            //modelBuilder.Entity<DivGeografica1>()
            //   .HasKey(c => new { c.Pais, c.CodDivGeografica1 });

            //modelBuilder.Entity<TipoCambio>()
            //    .HasIndex(p => p.CodTipoCambio, "IxTipoCambioId")
            //    .IsUnique();

            //modelBuilder.Entity<UnidadMedida>()
            //    .HasIndex(p => p.CodUnidadMedida, "IxUnidadMedidaId")
            //    .IsUnique();

            //modelBuilder.Entity<Pais>()
            //    .h

            //modelBuilder.Entity<NivelPrecio>()


            modelBuilder.Entity<Vendedor>()
                .HasIndex(p => p.CodVendedor, "IxVendedorId")
                .IsUnique();

            //modelBuilder.Entity<Zona>()
            //    .HasIndex(p => p.CodZona, "IxZonaId")
            //    .IsUnique();
        }

        
    }
}