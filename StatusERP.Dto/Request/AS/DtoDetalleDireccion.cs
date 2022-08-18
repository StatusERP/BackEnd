using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Dto.Request.AS
{
    public class DtoDetalleDireccion
    {
        public int CodDetalleDireccion { get; set; }

        public int DireccionId { get; set; }

        [StringLength(250)]
        public string? Campo01 { get; set; }

        [StringLength(250)]
        public string? Campo02 { get; set; }

        [StringLength(250)]
        public string? Campo03 { get; set; }

        [StringLength(250)]
        public string? Campo04 { get; set; }

        [StringLength(250)]
        public string? Campo05 { get; set; }

        [StringLength(250)]
        public string? Campo06 { get; set; }

        [StringLength(250)]
        public string? Campo07 { get; set; }

        [StringLength(250)]
        public string? Campo08 { get; set; }

        [StringLength(250)]
        public string? Campo09 { get; set; }

        [StringLength(250)]
        public string? Campo10 { get; set; }
    }
}