using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.ERPADMIN.Tablas
{
    [Table("BitacoraProceso", Schema = "ERPADMIN")]
    public class BitacoraProceso:EntityBase
    {
        [Required(ErrorMessage = "Número de Acción es requerido.")]
        public int LlaveBitProceso { get; set; }
        
        [Required(ErrorMessage = "El usuario es requerido.")]
        [StringLength(25)]
        public string Usuario { get; set; }
        
        [Required(ErrorMessage = "La compañía es requerido.")]
        [StringLength(10)]
        public string Compania { get; set; }
        
        [Required(ErrorMessage = "La fecha es requerida")]
        public DateTime Fecha { get; set; }
        
        [Required(ErrorMessage = "La estación es requerida.")]
        [StringLength(270)]
        public string Estacion { get; set; }
        
        [Required(ErrorMessage = "El proceso es requerido.")]
        [StringLength(50)]
        public string Proceso { get; set; }
        
        [Required(ErrorMessage = "El tipo es requerido.")]
        [StringLength(15)]
        public string Tipo { get; set; }
        
        [Required(ErrorMessage = "La descripción es requerido.")]
        [StringLength(512)]
        public string Descripcion { get; set; }
    }
}