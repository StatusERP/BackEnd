using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Entities.CP.Tablas
{
    public class HistoricoDifCambiarioCP:EntityBase
    {
        public int ConjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }
    }
}
