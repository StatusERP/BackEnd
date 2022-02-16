using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Entities.CC.Tablas
{
    public class SubTipoDocCC:EntityBase
    {
        public int ConjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }
    }
}
