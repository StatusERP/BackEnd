using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CI.Tablas
{
    [Table("PaqueteInv", Schema = Constants.Conjunto)]
    public class PaqueteInv:EntityBase
    {
        [Required(ErrorMessage = "El código del Paquete de Inventario es requerido")]
        [StringLength(4)]
        public string PaqueteInventario { get; set; }
        
        [Required(ErrorMessage = "La descripción del paquete de inventario es requerida.")]
        [StringLength(40)]
        public string Descripcion { get; set; }
        
        [Required(ErrorMessage = "Se debe registrar el último usuario.")]
        [StringLength(25)]
        public string UltimoUsuario { get; set; }
        
        [Required(ErrorMessage = "Se debe registrar el usuario que creó el paquete.")]
        [StringLength(25)]
        public string UsuarioCreador { get; set; }
        
        [Required(ErrorMessage = "Se debe registrar la fecha de último acceso.")]
        public DateTime FechaUltAceso { get; set; }
    }
}
