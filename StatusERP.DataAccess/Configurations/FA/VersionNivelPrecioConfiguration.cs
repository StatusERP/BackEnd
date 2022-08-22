using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Configurations.FA
{
    public class VersionNivelPrecioConfiguration : IEntityTypeConfiguration<VersionNivelPrecio>
    {
        public void Configure(EntityTypeBuilder<VersionNivelPrecio> builder)
        {
            builder
               .HasIndex(p => new { p.NivelPrecioId, p.Version}, "IxNivelPrecioId_Version")
               .IsUnique();
        }
    }
}
