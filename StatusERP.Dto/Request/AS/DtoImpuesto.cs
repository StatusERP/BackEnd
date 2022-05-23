using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Dto.Request.AS
{
    public class DtoImpuesto
    {
        [Required(ErrorMessage = "Se requiere especificar el Código del Impuesto")]
        [StringLength(4)]
        public string CodImpuesto { get; set; }

        [Required(ErrorMessage = "Se requiere especificar Descripciónl Impuesto")]
        [StringLength(40)]
        public string Descripcion { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal Impuesto1 { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal Impuesto2 { get; set; }

        public bool UsaImpuesto2Cantidad { get; set; }

        [Column(TypeName = "decimal(28,8)")]
        public decimal? Impuesto2Cantidad { get; set; }

        [Required(ErrorMessage = "Se requiere especificar cáculo Impuesto 2")]
        [StringLength(1)]
        public string CalculoImp2 { get; set; }

        [Required(ErrorMessage = "Se requiere indicar tipo de contabilización del Impuesto1")]
        [StringLength(1)]
        public string TipoContabImp1 { get; set; }

        [Required(ErrorMessage = "Se requiere indicar tipo de contabilización del Impuesto2")]
        [StringLength(1)]
        public string TipoContabImp2 { get; set; }

        public bool ContabDevImp1 { get; set; }

        public bool ContabDevImp2 { get; set; }

        public int? CtroCtaImp1GenId { get; set; }

        public int? CtroCtaImp2GenId { get; set; }

        public int? CtroCtaImp1GenVtsId { get; set; }

        public int? CtroCtaImp2GenVtsId { get; set; }

        public int? CtroCtaImp1DescCompId { get; set; }

        public int? CtroCtaImp2DescCompId { get; set; }

        public int? CtroCtaImp1DevCompId { get; set; }

        public int? CtroCtaImp2DevCompId { get; set; }

        public int? CtroCtaImp1DevVtsId { get; set; }

        public int? CtroCtaImp2DevVtsId { get; set; }

        public int? TipoImpuesto1Id { get; set; }

        public int? TipoImpuesto2Id { get; set; }

        [StringLength(2)]
        public string? TipoTarifa1 { get; set; }

        [StringLength(2)]
        public string? TipoTarifa2 { get; set; }

        public bool Activo { get; set; }
    }
}
