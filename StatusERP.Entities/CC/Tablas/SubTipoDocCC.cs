using StatusERP.Entities.CB.Tablas;
using StatusERP.Entities.CG.Tablas;
using StatusERP.Entities.FA.Tablas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.CC.Tablas
{
    [Table("SubTiposDocCC", Schema = Constants.Conjunto)]
    public class SubTipoDocCC:EntityBase
    {
        [StringLength(3)]
        public string Tipo { get; set; }

        public Int16 Subtipo { get; set; }

        public int? SubTipoCBId { get; set; }
        [ForeignKey(nameof(SubTipoCBId))]
        public SubTipoDocCB subTipoDocCB { get; set; }

        [StringLength(25)]
        public string Descripcion { get; set; }

        public int? CentroCuentaId { get; set; }
        [ForeignKey(nameof(CentroCuentaId))]
        public CentroCuenta centroCuenta { get; set; }

        public bool CalculaImp2 { get; set; }

        public int? TipoPartidaId { get; set; }
        [ForeignKey(nameof(TipoPartidaId))]
        public TipoPartida tipoPartida { get; set; }

        public int? PaqueteId { get; set; }
        [ForeignKey(nameof(PaqueteId))]
        public PaqueteContable paqueteContable { get; set; }

        [StringLength(10)]
        public string ? DocumentoGlobal { get; set; }

        [StringLength(4)]
        public string ? ConceptoNC { get; set; }

        [StringLength(4)]
        public string ? ConceptoFAC { get; set; }

        [StringLength(4)]
        public string ? ConceptoND { get; set; }

        [StringLength(4)]
        public string ? TipoDoc { get; set; }

        [StringLength(10)]
        public string ? TipoOperacFac { get; set; }

        [StringLength(10)]
        public string ? TipoOperacNC { get; set; }

        [StringLength(10)]
        public string ? TipoOperacND { get; set; }

        public int? ConsecutivoFacId { get; set; }
        [ForeignKey(nameof(ConsecutivoFacId))]
        public ConsecutivoFA consecutivoFA { get; set; }

    }
}
