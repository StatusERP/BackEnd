using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Configurations.AS
{
    public class TipoDocTributarioConfiguration : IEntityTypeConfiguration<TipoDocTributario>
    {
        public void Configure(EntityTypeBuilder<TipoDocTributario> builder)
        {
            builder
               .HasIndex(p => new { p.CodTipoDT}, "IxCodTipoDT")
               .IsUnique();
        }
    }
}

