using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CB.Tablas
{
    [Table("MovProcesados", Schema = Constants.Conjunto)]
    public class MovProcesados:EntityBase
    {
        [Required(ErrorMessage = "La cuenta bancaria es requerida.")]
        public int CuentaBancariaId { get; set; }
        public CuentaBancaria CuentaBancaria { get; set; }

        [Required(ErrorMessage = "El tipo de documento es requerido.")]
        [StringLength(3)]
        public string TipoDocumento { get; set; }

        [Required(ErrorMessage = "El número de documento es requerido.")]
        [Column(TypeName = "decimal(28,0)")]
        public decimal Numero { get; set; }

        [Required(ErrorMessage = "El nombre del archivo txt es requerido.")]
        [StringLength(250)]
        public string ArchivoTXT { get; set; }

        [Required(ErrorMessage = "La fecha de generación es requerida.")]
        public DateTime FechaGenerado { get; set; }

        [Required(ErrorMessage = "Se debe indicar el usuario que procesa.")]
        [StringLength(450)]
        public string UsuarioProcesa { get; set; }

        [Required(ErrorMessage = "Se debe indicar la fecha en que se procesa.")]
        public DateTime FechaProcesa { get; set; }
    }
}
