namespace StatusERP.Entities.ERPADMIN.Tablas
{
    public class Parentesco:EntityBase
    {
        public int ConjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }
    }
}
