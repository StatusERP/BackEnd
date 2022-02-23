using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    public class CondicionPago:EntityBase
    {
        [Required]
        [StringLength(4)]
        public string CodCondicionPago { get; set; }

        [Required]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [Required]
        public int DiasNeto { get; set; }

        [Required]
        public bool PagosParciales { get; set; }

        [Required]
        [Column(TypeName = "decimal(28,8)")]
        public decimal DescuentoContado { get; set; }

        [Required]
        [StringLength(2)]
        public string TipoCondPago { get; set; }

        public int ? PlazoCondPago { get; set; }

        [Required]
        public bool Activa { get; set; }    
    }
}
