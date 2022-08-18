using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Configurations.CG
{
    public class PaqueteContableConfiguration : IEntityTypeConfiguration<PaqueteContable>
    {
        public void Configure(EntityTypeBuilder<PaqueteContable> builder)
        {
            builder
                .HasIndex(p => new { p.CodPaquete}, "IxCodPaquete")
                .IsUnique();
        }
    }
}