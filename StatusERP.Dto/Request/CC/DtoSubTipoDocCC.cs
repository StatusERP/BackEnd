using System.ComponentModel.DataAnnotations;

namespace StatusERP.Dto.Request.CC
{
    public class DtoSubTipoDocCC
    {
        [Required(ErrorMessage = "El tipo es requerido.")]
        [StringLength(3)]
        public string Tipo { get; set; }

        public Int16 Subtipo { get; set; }

        public int? SubTipoCBId { get; set; }

        [Required(ErrorMessage = "La descripción es requerida.")]
        [StringLength(25)]
        public string Descripcion { get; set; }

        public int? CentroCuentaId { get; set; }

        public bool CalculaImp2 { get; set; }

        public int? TipoPartidaId { get; set; }

        public int? PaqueteId { get; set; }

        [StringLength(10)]
        public string? DocumentoGlobal { get; set; }

        [StringLength(4)]
        public string? ConceptoNC { get; set; }

        [StringLength(4)]
        public string? ConceptoFAC { get; set; }

        [StringLength(4)]
        public string? ConceptoND { get; set; }

        [StringLength(4)]
        public string? TipoDoc { get; set; }

        [StringLength(10)]
        public string? TipoOperacFac { get; set; }

        [StringLength(10)]
        public string? TipoOperacNC { get; set; }

        [StringLength(10)]
        public string? TipoOperacND { get; set; }

        public int? ConsecutivoFacId { get; set; }

    }
}
