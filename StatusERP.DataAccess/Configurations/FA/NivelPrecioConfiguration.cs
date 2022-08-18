using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Configurations.FA
{
    public class NivelPrecioConfiguration : IEntityTypeConfiguration<NivelPrecio> 
    {
        public void Configure(EntityTypeBuilder<NivelPrecio> builder)
        {
            builder
               .HasIndex(p => new { p.CodNivelPrecio, p.Moneda}, "IxCodNivelPrecio_Moneda")
               .IsUnique();
        }
    }
}
