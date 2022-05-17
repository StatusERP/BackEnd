using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Configurations.CI
{
    public class AjusteConfigConfiguration : IEntityTypeConfiguration<AjusteConfig>
    {
        public void Configure(EntityTypeBuilder<AjusteConfig> builder)
        {
            builder
                .HasIndex(p => p.CodAjusteConfig, "IxCodAjusteConfig")
                .IsUnique();
        }
    }
}

