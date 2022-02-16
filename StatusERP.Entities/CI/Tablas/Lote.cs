using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Entities.CI.Tablas
{
    public class Lote:EntityBase
    {
        public int ConjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }
    }
}
