using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.AS
{
    public class DtoRuta
    {
        [Required(ErrorMessage = "Se requiere especificar el código de la Ruta.")]
        [StringLength(4)]
        public string CodRuta { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la descripción de la Ruta.")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        public bool Activa { get; set; }
    }
}