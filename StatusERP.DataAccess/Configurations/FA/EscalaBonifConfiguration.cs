using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Configurations.FA
{
    public class EscalaBonifConfiguration : IEntityTypeConfiguration<EscalaBonif>
    {
        public void Configure(EntityTypeBuilder<EscalaBonif> builder)
        {
            builder
               .HasIndex(p => new { p.VersionNivelId, p.ArticuloId, p.NumEscalaBonif, p.VersionBonif }, "IxVersNiv_Art_NumEscala_VerBon")
               .IsUnique();
        }
    }
}
