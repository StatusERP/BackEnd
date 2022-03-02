using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.AS.Tablas
{
    public class CondicionPago:EntityBase
    {
        [Required(ErrorMessage = "Se requiere código para la Condición de Pago.")]
        [StringLength(4)]
        public string CodCondicionPago { get; set; }

        [Required(ErrorMessage = "Se requiere descripción para la Condición de Pago.")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Se requiere un valor para los días neto.")]
        public int DiasNeto { get; set; }

        [Required(ErrorMessage = "Se requiere un valor para los PagosParciales.")]
        public bool PagosParciales { get; set; }

        [Required(ErrorMessage = "Se requiere un valor para Descuento Contado.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal DescuentoContado { get; set; }

        [Required(ErrorMessage = "Se requiere un valor para tipo Condición Pago.")]
        [StringLength(2)]
        public string TipoCondPago { get; set; }

        public int ? PlazoCondPago { get; set; }

        public bool Activa { get; set; }    
    }
}
