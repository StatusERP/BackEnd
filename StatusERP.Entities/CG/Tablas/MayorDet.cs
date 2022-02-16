using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Entities.CG.Tablas
{
    public class MayorDet:EntityBase
    {
        public int ConjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }
    }
}
