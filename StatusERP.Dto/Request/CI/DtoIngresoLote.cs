using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Dto.Request.CI
{
    public class DtoIngresoLote
    {
        public int Articulo { get; set; }

        public int Lote { get; set; }

        public int SecuenciaLote { get; set; }

        public DateTime? FechaEntrada { get; set; }


        [Column(TypeName = "decimal(28,8)")]
        public decimal? CantidadIngresada { get; set; }
    }
}
