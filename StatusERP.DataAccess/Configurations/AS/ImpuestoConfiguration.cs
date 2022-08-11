using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Configurations.AS
{
    public class ImpuestoConfiguration : IEntityTypeConfiguration<Impuesto>
    {
        public void Configure(EntityTypeBuilder<Impuesto> builder)
        {
            builder
                .HasIndex(p => new { p.CodImpuesto }, "IxCodImpuesto")
                .IsUnique();

        }
    }
}