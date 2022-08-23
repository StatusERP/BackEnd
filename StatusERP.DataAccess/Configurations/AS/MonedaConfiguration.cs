using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Configurations.AS
{
    public class MonedaConfiguration : IEntityTypeConfiguration<Moneda>
    {
        public void Configure(EntityTypeBuilder<Moneda> builder)
        {
            builder
               .HasIndex(p => new { p.CodMoneda }, "IxCodMoneda")
               .IsUnique();
        }
    }
}
