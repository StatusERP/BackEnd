using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.FA
{
    public class DtoDireccEmbarque
    {
        [Required(ErrorMessage = "El cliente es requerido.")]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "La dirección es requerida.")]
        [StringLength(8)]
        public string Direccion { get; set; }

        public int? DetalleDireccionId { get; set; }

        public string? Descripcion { get; set; }

        [StringLength(30)]
        public string? Contacto { get; set; }

        [StringLength(30)]
        public string? Cargo { get; set; }

        [StringLength(50)]
        public string? Telefono1 { get; set; }

        [StringLength(50)]
        public string? Telefono2 { get; set; }

        [StringLength(50)]
        public string? Fax { get; set; }

        [StringLength(50)]
        public string? Email { get; set; }

    }
}
