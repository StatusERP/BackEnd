using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Dto.Request.CI
{
    public class DtoExistenciaLote
    {
        public int BodegaId { get; set; }

        public int ArticuloId { get; set; }

        public int LocalizacionId { get; set; }

        public int LoteId { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal CantDisponible { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal CantReservada { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal CantNoAprobada { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal CantVencida { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal CantRemitida { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoUntLoc { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal CostoUntDol { get; set; }
    }
}
