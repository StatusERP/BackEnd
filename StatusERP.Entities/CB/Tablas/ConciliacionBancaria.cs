using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Entities.CB.Tablas
{
    public class ConciliacionBancaria:EntityBase
    {
        public int ConjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }
    }
}
