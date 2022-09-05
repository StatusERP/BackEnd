using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Configurations.FA
{
    public class ConsecutivoFAConfiguration : IEntityTypeConfiguration<ConsecutivoFA>
    {
        public void Configure(EntityTypeBuilder<ConsecutivoFA> builder)
        {
            builder
               .HasIndex(p => new { p.CodConsecutivo}, "IxCodConsecutivo")
               .IsUnique();
        }
    }
}
