using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    [Table("CondicionesPago", Schema = Constants.Conjunto)]
    public class CondicionPago:EntityBase
    {

        [StringLength(4)]
        public string CodCondicionPago { get; set; }

        [StringLength(40)]
        public string Descripcion { get; set; }

        public int DiasNeto { get; set; }

        public bool PagosParciales { get; set; }


        [Column(TypeName = "decimal(28,8)")]
        public decimal DescuentoContado { get; set; }

        [StringLength(2)]
        public string TipoCondPago { get; set; }

        public int ? PlazoCondPago { get; set; }

        public bool Activa { get; set; }    
    }
}
