using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.CB.Tablas;

namespace StatusERP.DataAccess.Configurations.FA
{
    public class SubTipoDocCBConfiguration : IEntityTypeConfiguration<SubTipoDocCB>
    {
        public void Configure(EntityTypeBuilder<SubTipoDocCB> builder)
        {
            builder
               .HasIndex(p => new { p.Tipo, p.SubTipo }, "IxTipo_SubTipo")
               .IsUnique();
        }
    }
}
