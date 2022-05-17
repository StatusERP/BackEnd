using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Configurations.CI
{
    public class AjusteSubSubTipoConfiguration : IEntityTypeConfiguration<AjusteSubSubTipo>
    {
        public void Configure(EntityTypeBuilder<AjusteSubSubTipo> builder)
        {
            builder
                .HasIndex(p => new { p.AjusteConfig, p.Subsubtipo }, "IxAjusteSubsubtipo")
                .IsUnique();

        }
    }
}