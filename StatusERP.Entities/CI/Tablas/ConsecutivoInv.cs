using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("ConsecutivosInv", Schema = Constants.Conjunto)]
    public class ConsecutivoInv:EntityBase
    {
        [Required]
        [StringLength(10)]
        public string CodConsecutivo { get; set; }
        
        [Required]
        [StringLength(25)]
        public string UltimoUsuario { get; set; }
        
        [Required]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(50)]
        public string Mascara { get; set; }
        
        [Required]
        [StringLength(50)]
        public string SiguienteConsec { get; set; }
        
        public bool Editable { get; set; }
        
        public bool MultiplesTrans { get; set; }
        
        [StringLength(250)]
        public string ? FormatoImp { get; set; }
        
        public DateTime UltFechaHora { get; set; }
        
        public bool TodasTrans { get; set; }
        
        [Required]
        [StringLength(4)]
        public string Tipo { get; set; }
        
        public bool UsaTraslado { get; set; }
        
        [StringLength(250)]
        public string ? EmailCFDI { get; set; }
    }
}
