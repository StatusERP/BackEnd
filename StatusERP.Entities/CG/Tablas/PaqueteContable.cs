using System.ComponentModel.DataAnnotations;

namespace StatusERP.Entities.CG.Tablas
{
    public class PaqueteContable:EntityBase
    {
        [Required]
        [StringLength(4)]
        public string CodPaquete { get; set; }

        [Required]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(25)]
        public string UsuarioCreador { get; set; }

        [Required]
        [StringLength(25)]
        public string UltimoUsuario { get; set; }

        [Required]
        public DateTime FechaUltAcceso { get; set; }

        [Required]
        [StringLength(10)]
        public string UltimoAsientoFiscal { get; set; }

        [StringLength(10)]
        public string ? UltimoAsientoCorp { get; set; }

        [Required]
        public bool Marcado { get; set; }
    }
}
