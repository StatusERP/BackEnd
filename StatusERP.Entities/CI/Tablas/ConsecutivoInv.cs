using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("ConsecutivosInv", Schema = Constants.Conjunto)]
    public class ConsecutivoInv:EntityBase
    {
        [Required(ErrorMessage = "El código del consecutivo es requerido.")]
        [StringLength(10)]
        public string CodConsecutivo { get; set; }
        
        [Required(ErrorMessage = "El último usuario es requerido.")]
        [StringLength(25)]
        public string UltimoUsuario { get; set; }
        
        [Required(ErrorMessage = "La descripción del consecutivo es requerida.")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La máscara es requerida.")]
        [StringLength(50)]
        public string Mascara { get; set; }
        
        [Required(ErrorMessage = "El siguiente consecutivo es requerido.")]
        [StringLength(50)]
        public string SiguienteConsec { get; set; }
        
        public bool Editable { get; set; }
        
        public bool MultiplesTrans { get; set; }
        
        [StringLength(250)]
        public string ? FormatoImp { get; set; }
        
        [Required(ErrorMessage = "Debe indicar fecha y hora del último acceso.")]
        public DateTime UltFechaHora { get; set; }
        
        public bool TodasTrans { get; set; }
        
        [Required(ErrorMessage = "El tipo es requerido.")]
        [StringLength(4)]
        public string Tipo { get; set; }
        
        public bool UsaTraslado { get; set; }
        
        [StringLength(250)]
        public string ? EmailCFDI { get; set; }
    }
}
