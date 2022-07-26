using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Configurations.CI
{
    public class DocumentoInvDetConfiguration : IEntityTypeConfiguration<DocumentoInvDet>
    {
        public void Configure(EntityTypeBuilder<DocumentoInvDet> builder)
        {
            builder
                .HasIndex(p => new { p.PaqueteInventarioId, p.DocumentoInv, p.LineaDocInv  }, "IxDocInvDet_PaqDocLin")
                .IsUnique();

        }
    }
}