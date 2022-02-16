using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Entities.CC.Tablas
{
    public class GlobalesCC:EntityBase
    {
        public int ConjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }
    }
}
