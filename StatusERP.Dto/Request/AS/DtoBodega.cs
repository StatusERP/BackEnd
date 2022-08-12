using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.AS
{
    public class DtoBodega
    {
        [Required(ErrorMessage = "Se requiere especificar un código de Bodega")]
        [StringLength(4)]
        public string CodBodega { get; set; }

        [Required(ErrorMessage = "Se requiere especificar un Nombre de Bodega")]
        [StringLength(40)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el Tipo de Bodega")]
        [StringLength(1)]
        public string Tipo { get; set; }

        public bool Activa { get; set; }

        [StringLength(15)]
        public string? Telefono { get; set; }

        [StringLength(250)]
        public string? Direccion { get; set; }
    }
}