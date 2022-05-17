using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Configurations.CI
{
    public class AjusteSubTipoConfiguration : IEntityTypeConfiguration<AjusteSubTipo>
    {
        public void Configure(EntityTypeBuilder<AjusteSubTipo> builder)
        {
            builder
                .HasIndex(p => new { p.AjusteConfig, p.SubTipo }, "IxAjusteSubtipo")
                .IsUnique();
                
        }
    }
}
