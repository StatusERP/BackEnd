using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Configurations.CI
{
    public class PaqueteInvConfiguration : IEntityTypeConfiguration<PaqueteInv>
    {
        public void Configure(EntityTypeBuilder<PaqueteInv> builder)
        {
            builder
                .HasIndex(p => new { p.CodPaqueteInv}, "IxCodPaqueteInv")
                .IsUnique();
        }
    }
}