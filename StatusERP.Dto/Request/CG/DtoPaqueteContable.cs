using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.CG
{
    public class DtoPaqueteContable
    {
        [Required(ErrorMessage = "Se debe indicar el código del Paquete Contable")]
        [StringLength(4)]
        public string CodPaquete { get; set; }

        [Required(ErrorMessage = "Se debe indicar la Descripción del Paquete Contable")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Usuario Creador es requerido.")]
        [StringLength(250)]
        public string UsuarioCreador { get; set; }

        [Required(ErrorMessage = "Ultimo Usuario es requerido")]
        [StringLength(250)]
        public string UltimoUsuario { get; set; }

        public DateTime FechaUltAcceso { get; set; }

        [Required(ErrorMessage = "Ultimo Asiento es requerido.")]
        [StringLength(10)]
        public string UltimoAsiento { get; set; }

        public bool Marcado { get; set; }

    }
}
