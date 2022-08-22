using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Configurations.FA
{
    public class DireccEmbarqueConfiguration : IEntityTypeConfiguration<DireccEmbarque>
    {
        public void Configure(EntityTypeBuilder<DireccEmbarque> builder)
        {
            builder
               .HasIndex(p => new { p.ClienteId, p.Direccion}, "IxClienteId_Direccion")
               .IsUnique();
        }
    }
}

