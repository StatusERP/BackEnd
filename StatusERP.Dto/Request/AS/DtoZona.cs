using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.AS
{
    public class DtoZona
    {

        [Required(ErrorMessage = "Se requiere especificar el código de la Zona.")]
        [StringLength(4)]
        public string CodZona { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la Descripción de la Zona.")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        public bool Activa { get; set; }
    }
}
