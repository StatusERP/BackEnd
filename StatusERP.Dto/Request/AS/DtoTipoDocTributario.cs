using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.AS
{
    public class DtoTipoDocTributario
    {
        [Required(ErrorMessage = "Se requiere especificar el código del Tipo de Documento Tributario")]
        [StringLength(25)]
        public string CodTipoDT { get; set; }

        [Required(ErrorMessage = "Se requiere especificar descripción del Tipo de Documento Tributario.")]
        [StringLength(25)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Se requiere especificar la máscara que corresponde al Tipo de Documento Tributario.")]
        [StringLength(20)]
        public string Mascara { get; set; }
    }
}