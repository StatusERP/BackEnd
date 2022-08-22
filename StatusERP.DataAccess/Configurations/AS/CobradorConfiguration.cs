using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Configurations.AS
{
    public class CobradorConfiguration : IEntityTypeConfiguration<Cobrador>
    {
        public void Configure(EntityTypeBuilder<Cobrador> builder)
        {
            builder
               .HasIndex(p => new { p.CodCobrador }, "IxCodCobrador")
               .IsUnique();
        }
    }
}
