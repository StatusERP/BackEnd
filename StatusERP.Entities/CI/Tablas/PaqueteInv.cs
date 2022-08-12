using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("PaquetesInv", Schema = Constants.Conjunto)]
    public class PaqueteInv:EntityBase
    {
        [StringLength(4)]
        public string CodPaqueteInv { get; set; }
        
        [StringLength(40)]
        public string Descripcion { get; set; }
        
        [StringLength(450)]
        public string UltimoUsuario { get; set; }
        
        [StringLength(450)]
        public string UsuarioCreador { get; set; }
        
        public DateTime FechaUltAcceso { get; set; }
    }
}
