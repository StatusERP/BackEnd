using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("DocumentosInvEnc", Schema = Constants.Conjunto)]
    public class DocumentoInvEnc:EntityBase
    {
  
        [StringLength(10)]
        public string ? Consecutivo { get; set; }
        
        [Required(ErrorMessage = "Debe indicarse el usuario.")]
        [StringLength(25)]
        public string Usuario { get; set; }
        
        [Required(ErrorMessage = "Debe indicarse una fecha.")]
        public DateTime FechaHora { get; set; }
        
        [Required(ErrorMessage = "Debe indicarse el módulo origen.")]
        [StringLength(4)]
        public string ModuloOrigen { get; set; }
        
        [Required(ErrorMessage = "Debe ingresarse una aplicación.")]
        [StringLength(250)]
        public string Aplicacion { get; set; }
        
        [Required(ErrorMessage = "Debe ingresarse una referencia.")]
        [StringLength(200)]
        public string Referencia { get; set; }
        
        [StringLength(10)]
        public string ? Asiento { get; set; }

        [StringLength(25)]
        public string ? UsuarioAprob { get; set; }
        
        [Required(ErrorMessage = "Debe indicarse el usuario.")]
        public DateTime ? FechaoAprob { get; set; }
        
        [StringLength(4)]
        public string ? PaqueteInventario { get; set; }
    }
}
