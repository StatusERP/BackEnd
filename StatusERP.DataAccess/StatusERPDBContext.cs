﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.AS.Tablas;
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
        public DbSet<Conjunto> Conjuntos { get; set; }

        public DbSet<Vendedor> Vendedores { get; set; }
      
        public DbSet<Bodega> Bodegas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Bodega>()
                .HasIndex(p => p.CodBodega, "IxBodegaId")
                .IsUnique();

            modelBuilder.Entity<CategoriaCliente>()
                .HasIndex(p => p.CodCategoriaCliente, "IxCategoriaClienteId")
                .IsUnique();

            modelBuilder.Entity<CategoriaProveedor>()
                .HasIndex(p => p.CodCategoriaProveedor, "IxCategoriaProveedorId")
                .IsUnique();

            modelBuilder.Entity<CentroCosto>()
                .HasIndex(p => p.CodCentroCosto, "IxCentroCostoId")
                .IsUnique();

            modelBuilder.Entity<Cobrador>()
                .HasIndex(p => p.CodCobrador, "IxCobradorId")
                .IsUnique();

            modelBuilder.Entity<Vendedor>()
                .HasIndex(p => p.CodVendedor, "IxVendedorId")
                .IsUnique();

            modelBuilder.Entity<Localizacion>()
                .Property(p => p.Volumen)
                .HasPrecision(28, 8);



        }

    }
}