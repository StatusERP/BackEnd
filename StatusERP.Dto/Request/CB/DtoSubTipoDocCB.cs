using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.CB
{
    public class DtoSubTipoDocCB
    {
        [Required(ErrorMessage = "El de tipo de documento CB es requerido.")]
        [StringLength(3)]
        public string Tipo { get; set; }

        public Int16 SubTipo { get; set; }

        [Required(ErrorMessage = "La descripción es requerida.")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        public int? CentroCuentaId { get; set; }

        public int? TipoPartidaId { get; set; }

        public int? PaqueteId { get; set; }

        [StringLength(10)]
        public string? DocumentoGlobal { get; set; }

        [StringLength(20)]
        public string? RubroCF { get; set; }

        [StringLength(20)]
        public string? RubroPadre { get; set; }

        [StringLength(20)]
        public string? FlujoCaja { get; set; }

        [StringLength(1)]
        public string? NaturalezaCF { get; set; }
    }
}
