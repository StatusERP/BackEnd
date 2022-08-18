using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.AS
{
    public class DtoDireccion
    {
        [Required(ErrorMessage = "El código de la descripción es requerido.")]
        [StringLength(10)]
        public string CodDireccion { get; set; }

        [Required(ErrorMessage = "La descripción de la dirección es requerida.")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [StringLength(60)]
        public string? NombreCampo01 { get; set; }

        [StringLength(60)]
        public string? NombreCampo02 { get; set; }

        [StringLength(60)]
        public string? NombreCampo03 { get; set; }

        [StringLength(60)]
        public string? NombreCampo04 { get; set; }

        [StringLength(60)]
        public string? NombreCampo05 { get; set; }

        [StringLength(60)]
        public string? NombreCampo06 { get; set; }

        [StringLength(60)]
        public string? NombreCampo07 { get; set; }

        [StringLength(60)]
        public string? NombreCampo08 { get; set; }

        [StringLength(60)]
        public string? NombreCampo09 { get; set; }

        [StringLength(60)]
        public string? NombreCampo10 { get; set; }

    }
}
