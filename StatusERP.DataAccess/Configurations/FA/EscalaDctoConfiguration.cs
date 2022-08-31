using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Configurations.FA
{
    public class EscalaDctoConfiguration : IEntityTypeConfiguration<EscalaDcto>
    {
        public void Configure(EntityTypeBuilder<EscalaDcto> builder)
        {
            builder
               .HasIndex(p => new { p.VersionNivelId, p.ArticuloId, p.NumEscalaDcto, p.VersionDcto }, "IxVersNiv_Art_NumEscala_VerDcto")
               .IsUnique();
        }
    }
}
