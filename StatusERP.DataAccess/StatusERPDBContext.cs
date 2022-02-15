using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.DataAccess
{
    public class StatusERPDBContext:DbContext
    {
        public StatusERPDBContext()
        {

        }

        public StatusERPDBContext(DbContextOptions<StatusERPDBContext> options): base(options)
        {

        }
        public DbSet<Conjunto> Conjuntos { get; set; }
    }
}