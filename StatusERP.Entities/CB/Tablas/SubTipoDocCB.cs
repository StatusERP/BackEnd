using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.Entities.CB.Tablas
{
    [Table("SubTiposDocCB", Schema = Constants.Conjunto)]
    public class SubTipoDocCB:EntityBase
    {
        [StringLength(3)]
        public string Tipo { get; set; }

        public Int16 SubTipo { get; set; }

        [StringLength(40)]
        public string Descripcion { get; set; }

        public int ? CentroCuentaId { get; set; }
        [ForeignKey(nameof(CentroCuentaId))]
        public CentroCuenta centroCuenta { get; set; }
                
        public int? TipoPartidaId { get; set; }
        [ForeignKey(nameof(TipoPartidaId))]
        public TipoPartida tipoPartida { get; set; }

        public int? PaqueteId { get; set; }
        [ForeignKey(nameof(PaqueteId))]
        public PaqueteContable paqueteContable { get; set; }

        [StringLength(10)]
        public string ? DocumentoGlobal { get; set; }

        [StringLength(20)]
        public string ? RubroCF { get; set; }

        [StringLength(20)]
        public string ? RubroPadre { get; set; }

        [StringLength(20)]
        public string ? FlujoCaja { get; set; }

        [StringLength(1)]
        public string ? NaturalezaCF { get; set; }
    }
}
