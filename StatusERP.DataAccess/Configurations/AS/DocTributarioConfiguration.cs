using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Configurations.AS
{
    public class DocTributarioConfiguration : IEntityTypeConfiguration<DocTributario>
    {
        public void Configure(EntityTypeBuilder<DocTributario> builder)
        {
            builder
                .HasIndex(p => new { p.NumDocTributario}, "IxNumDocT")
                .IsUnique();

        }
    }
}
