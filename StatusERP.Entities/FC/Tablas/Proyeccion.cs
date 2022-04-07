using StatusERP.Entities.AS.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FC.Tablas
{
    [Table("Proyecciones", Schema = Constants.Conjunto)]
    public class Proyeccion:EntityBase
    {
        [StringLength(10)]
        public string ? Asiento { get; set; }

        [Required(ErrorMessage = "Se debe indicar la descripción.")]
        [StringLength(250)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Se debe indicar la fecha de creación.")]
        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaModificacion { get; set; }

        [Required(ErrorMessage = "Se debe indicar el código de la inversión.")]
        [StringLength(20)]
        public string CodProyeccion { get; set; }

        [Required(ErrorMessage = "Se debe indicar el monto total en dólares.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoTotalDolar { get; set; }

        [Required(ErrorMessage = "Se debe indicar el monto totalen moneda local.")]
        [Column(TypeName = "decimal(28,8)")]
        public decimal MontoTotalLocal { get; set; }

        [Required(ErrorMessage = "Se debe indicar la naturaleza.")]
        [StringLength(1)]
        public string Naturaleza { get; set; }

        public int? DocTributarioId { get; set; }
        public DocTributario DocTributario { get; set; }

        [StringLength(4)]
        public string ? Origen { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? TipoCambio { get; set; }

        [Required(ErrorMessage = "El usuario creación es requerido.")]
        [StringLength(450)]
        public string UsuarioCreacion { get; set; }

        [StringLength(450)]
        public string? UsuarioModificacion { get; set; }
    }
}
