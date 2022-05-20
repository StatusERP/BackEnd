using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Configurations.CI
{
    public class DocumentoInvEncConfiguration : IEntityTypeConfiguration<DocumentoInvEnc>
    {
        public void Configure(EntityTypeBuilder<DocumentoInvEnc> builder)
        {
            builder
                .HasIndex(p => new { p.PaqueteInventario, p.DocumentoInv }, "IxDocInvEnc_PaqDoc")
                .IsUnique();

        }
    }
}