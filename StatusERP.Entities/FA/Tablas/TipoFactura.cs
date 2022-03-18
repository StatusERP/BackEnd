using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("TiposFactura", Schema = Constants.Conjunto)]
    public class TipoFactura:EntityBase
    {   [Required(ErrorMessage = "El código es requerido.")]
        [StringLength(10)]
        public string Codigo { get; set; }
        
        [Required(ErrorMessage = "La descripción es requerida.")]
        [StringLength(100)]
        public string Descripcion { get; set; }
        
        [StringLength(30)]
        public string ? Factura { get; set; }
        
        [StringLength(30)]
        public string ? Boleta { get; set; }

        [StringLength(30)]
        public string ? LiquidacionCompra { get; set; }
    }
}
