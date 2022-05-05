using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Dto.Request.CI
{
    public class DtoPaqueteInv
    {
        [Required(ErrorMessage = "El código del Paquete de Inventario es requerido")]
        [StringLength(4)]
        public string CodPaqueteInv { get; set; }

        [Required(ErrorMessage = "La descripción del paquete de inventario es requerida.")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Se debe registrar el último usuario.")]
        [StringLength(450)]
        public string UltimoUsuario { get; set; }

        [Required(ErrorMessage = "Se debe registrar el usuario que creó el paquete.")]
        [StringLength(450)]
        public string UsuarioCreador { get; set; }

        [Required(ErrorMessage = "Se debe registrar la fecha de último acceso.")]
        public DateTime FechaUltAcceso { get; set; }
    }
}
