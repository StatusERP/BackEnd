using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Configurations.CI
{
    public class ConsecutivoInvConfiguration : IEntityTypeConfiguration<ConsecutivoInv>
    {
        public void Configure(EntityTypeBuilder<ConsecutivoInv> builder)
        {
            builder
                .HasIndex(p => p.CodConsecutivo, "IxCodConsecutivo")
                .IsUnique();
        }
    }
}

