using StatusERP.Entities.AS.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CB.Tablas
{
    [Table("Cheques", Schema = Constants.Conjunto)]
    public class Cheque:EntityBase
    {
        [Required(ErrorMessage = "El número de cheque es requerido.")]
        public int ChequeId { get; set; }

        [Required(ErrorMessage = "La cuenta bancaria es requerida.")]
        public int CuentaBancariaId { get; set; }
        public CuentaBancaria CuentaBancaria { get; set; }

        [StringLength(3)]
        public string ? Tipo { get; set; }

        public Int16 ? SubTipo { get; set; }

        [StringLength(150)]
        public string ? PagaderoA { get; set; }

        [Required(ErrorMessage = "La referencia es requerida.")]
        [StringLength(250)]
        public string Referencia { get; set; }

        [Required(ErrorMessage = "El monto es requerido.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "El usuario creación es requerido.")]
        [StringLength(450)]
        public string UsuarioCreacion { get; set; }

        public DateTime ? FechaHoraModific { get; set; }

        [StringLength(450)]
        public string ? UsuarioModific { get; set; }

        public DateTime ? FechaHoraUltAplic { get; set; }

        public bool Recurrente { get; set; }

        public string ? Concepto { get; set; }

        public int ? DocTributarioId { get; set; }
        public DocTributario DocTributario { get; set; }

        public bool Seleccionado { get; set; }

        [Required(ErrorMessage = "La fecha y hora de creación son requeridas.")]
        public DateTime FechaHoraCreacion { get; set; }

        [StringLength(450)]
        public string ? UsuarioUltAplic { get; set; }

        [StringLength(100)]
        public string ? ResponsableSolic { get; set; }

        public bool Aprobado { get; set; }

        [Required(ErrorMessage = "El origen de la solicitud es requerido.")]
        [StringLength(40)]
        public string OrigenSolicitud { get; set; }

        [StringLength(50)]
        public string ? DocumentoGlobal { get; set; }

        [StringLength(10)]
        public string ? MetodoPago { get; set; }
    }
}
