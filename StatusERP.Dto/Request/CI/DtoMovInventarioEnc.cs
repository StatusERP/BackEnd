using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Dto.Request.CI
{
    public class DtoMovInventarioEnc
    {
        public int Id { get; set; }

        public int? ConsecutivoId { get; set; }

        [Required(ErrorMessage = "Debe indicarse el usuario.")]
        [StringLength(25)]
        public string Usuario { get; set; }

        public DateTime FechaHora { get; set; }

        [Required(ErrorMessage = "Debe indicarse el módulo origen.")]
        [StringLength(4)]
        public string ModuloOrigen { get; set; }

        [Required(ErrorMessage = "Debe indicarse la aplicación.")]
        [StringLength(250)]
        public string Aplicacion { get; set; }

        [Required(ErrorMessage = "Debe indicarse la referencia.")]
        [StringLength(200)]
        public string Referencia { get; set; }

        [StringLength(10)]
        public string? Asiento { get; set; }

        [StringLength(25)]
        public string? UsuarioAprob { get; set; }
        public DateTime? FechaHoraAprob { get; set; }

        [StringLength(4)]
        public String? PaqueteInventario { get; set; }
    }
}
