using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Entities.CP.Tablas
{
    public class Proveedor:EntityBase
    {
        public int ConjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }
    }
}
