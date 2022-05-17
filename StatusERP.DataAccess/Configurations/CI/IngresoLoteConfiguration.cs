using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Configurations.CI
{
    public class IngresoLoteConfiguration : IEntityTypeConfiguration<IngresoLote>
    {
        public void Configure(EntityTypeBuilder<IngresoLote> builder)
        {
            builder
                .HasIndex(p => new { p.Articulo, p.Lote, p.SecuenciaLote }, "IxArtLoteSecLote")
                .IsUnique();

        }
    }
}