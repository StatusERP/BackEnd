using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Configurations.CI
{
    public class TipoImpuestoConfiguration : IEntityTypeConfiguration<TipoImpuesto>
    {
        public void Configure(EntityTypeBuilder<TipoImpuesto> builder)
        {
            builder
                .HasIndex(p => new { p.CodTipoImpuesto }, "IxCodTipoImpuesto")
                .IsUnique();

        }
    }
}