using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("PedidoEncs", Schema = Constants.Conjunto)]
    public class PedidoEnc:EntityBase
    {
        public string Pedido { get; set; }

        public string Estado { get; set; }

        public DateTime FechaPedido { get; set; }

        public DateTime Fecha_Prometida { get; set; }

        public DateTime FechaProxEmbarqu { get; set; }

        public DateTime FechaUltEmbarque { get; set;}

        public DateTime FechaUltCancelac { get; set; }

        public string OrdenCompra { get; set; }

        public DateTime FechaOrden { get; set; }

        public string TarjetaCredito { get; set; }

        public string EmbarcarA { get; set; }

        public string DirecEmbarque { get; set; }

        [StringLength (50)]
        public string Rubro1 { get; set; }

        [StringLength(50)]
        public string Rubro2 { get; set; }

        [StringLength(50)]
        public string Rubro3 { get; set; }

        [StringLength(50)]
        public string Rubro4 { get; set; }

        [StringLength(50)]
        public string Rubro5 { get; set; }

        public string Observaciones { get; set; }

        public string ComentarioCXC { get; set; }

        public decimal TotalMercaderia { get; set; }

        public decimal MontoAnticipo { get; set; }

        public decimal MontoFlete { get; set; }

        public decimal MontoSeguro { get; set; }

        public string TipoDescuento1 { get; set; }

        public string TipoDescuento2 { get; set; }

        public string MontoDescuento1 { get; set; }

        public string MontoDescuento2 { get; set; }

        public decimal PorcDescuento1 { get; set; }

        public decimal PorcDescuento2 { get; set; }

        public decimal TotalImpuesto1 { get; set; }

        public decimal TotalImpuesto2 { get; set; }


        public decimal TotalAFacturar { get; set; }

        public decimal PorcComiVendedor { get; set; }

        public decimal PorcComiCobrador { get; set; }

        public decimal TotalCancelado { get; set; }

        public decimal TotalUnidades { get; set; }

        public bool Impreso { get; set; }

        public DateTime FechaHora { get; set; }

        public decimal DescuentoVolumen { get; set; }

        public string TipoPedido { get; set; }

        public string MonedaPedido { get; set; }

        public int VersionNP { get; set; }

        public bool Autorizado { get; set; }

        public string DocAGenerar { get; set; }

        public string ClasePedido { get; set; }

        public string Moneda { get; set; }

        public string NivelPrecio { get; set; }

        public string Cobrador { get; set; }

        public string Ruta { get; set; }

        public string Usuario { get; set; }

        public string CondicionPago { get; set; }

        public string Bodega { get; set; }

        public string Zona { get; set; }

        public string Vendedor { get; set; }

        public string Cliente { get; set; }

        public string ClienteDireccion { get; set; }

        public string ClienteCorporac { get; set; }

        public string ClienteOrigen { get; set; }

        public string Pais { get; set; }

        public Int16 SubtipoDocCXC { get; set; }


        public string TipoDocCXC { get; set; }

        public string Backorder { get; set; }

        public decimal PorcIntCte { get; set; }















    }
}
