using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Configurations.AS
{
    public class CondicionPagoConfiguration : IEntityTypeConfiguration<CondicionPago>
    {
        public void Configure(EntityTypeBuilder<CondicionPago> builder)
        {
            builder
               .HasIndex(p => new { p.CodCondicionPago }, "IxCodCondicionPago")
               .IsUnique();
        }
    }
}
