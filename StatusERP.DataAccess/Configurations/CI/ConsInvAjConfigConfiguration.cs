using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Configurations.CI
{
    public class ConsInvAjConfigConfiguration : IEntityTypeConfiguration<ConsInvAjConfig>
    {
        public void Configure(EntityTypeBuilder<ConsInvAjConfig> builder)
        {
            builder
                .HasIndex(p => new { p.ConsecutivoInvId, p.AjusteConfigId }, "IxConsecutivoAjuste")
                .IsUnique();

        }
    }
}