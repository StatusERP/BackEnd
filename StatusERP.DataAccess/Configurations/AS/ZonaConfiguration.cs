using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Configurations.AS
{
    public class ZonaConfiguration : IEntityTypeConfiguration<Zona>
    {
        public void Configure(EntityTypeBuilder<Zona> builder)
        {
            builder
                .HasIndex(p => new {p.CodZona}, "IxCodZona")
                .IsUnique();

        }
    }
}
