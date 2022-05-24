using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Configurations.CI
{
    public class MovInventarioDetConfiguration : IEntityTypeConfiguration<MovInventarioDet>
    {
        public void Configure(EntityTypeBuilder<MovInventarioDet> builder)
        {
            builder
                .HasIndex(p => new { p.MovInventarioEncId, p.Consecutivo}, "IxMovInvEnc_Consec")
                .IsUnique();

        }
    }
}