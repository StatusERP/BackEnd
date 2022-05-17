using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Dto.Request.CI
{
    public class DtoAjusteConfig
    {
        [Required(ErrorMessage = "El código del ajuste es requerido.")]
        [StringLength(4)]
        public string CodAjusteConfig { get; set; }

        [Required(ErrorMessage = "La descripción es requerida.")]
        [StringLength(15)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el tipo de ajuste base.")]
        [StringLength(1)]
        public string AjusteBase { get; set; }

        public bool Activa { get; set; }

        [Required(ErrorMessage = "Debe indicarse el tipo de ingreso.")]
        [StringLength(1)]
        public string Ingreso { get; set; }
    }
}
