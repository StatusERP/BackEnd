using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatusERP.Entities.FA.Tablas
{
    [Table("PedidoEncs", Schema = Constants.Conjunto)]
    public class PedidoEnc:EntityBase
    {
        [StringLength(50) ]
        public string Pedido { get; set; }

        [StringLength(1)]
        public string Estado { get; set; }

        public DateTime FechaPedido { get; set; }

        public DateTime Fecha_Prometida { get; set; }

        public DateTime FechaProxEmbarqu { get; set; }

        public DateTime FechaUltEmbarque { get; set;}

        public DateTime FechaUltCancelac { get; set; }

        [StringLength(30)]
        public string OrdenCompra { get; set; }

        public DateTime FechaOrden { get; set; }

        [StringLength(20)]
        public string TarjetaCredito { get; set; }

        [StringLength(160)]
        public string EmbarcarA { get; set; }

        [StringLength(8)]
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

        [StringLength(40)]
        public string ComentarioCXC { get; set; }

        public decimal TotalMercaderia { get; set; }

        public decimal MontoAnticipo { get; set; }

        public decimal MontoFlete { get; set; }

        public decimal MontoSeguro { get; set; }

        [StringLength(1)]
        public string TipoDescuento1 { get; set; }

        [StringLength(1)]
        public string TipoDescuento2 { get; set; }

        public decimal MontoDescuento1 { get; set; }

        public decimal MontoDescuento2 { get; set; }

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

        [StringLength(1)]
        public string TipoPedido { get; set; }

        [StringLength(1)]
        public string MonedaPedido { get; set; }

        public int VersionNP { get; set; }

        public bool Autorizado { get; set; }

        [StringLength(1)]
        public string DocAGenerar { get; set; }

        [StringLength(1)]
        public string ClasePedido { get; set; }

        [StringLength(1)]
        public string Moneda { get; set; }

        [StringLength(12)]
        public string NivelPrecio { get; set; }

        [StringLength(4)]
        public string Cobrador { get; set; }

        [StringLength(4)]
        public string Ruta { get; set; }

        [StringLength(25)]
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

        public bool DescuentoCascada { get; set; }

        public string DireccionFactura { get; set; }

        public decimal TipoCambio { get; set; }

        public bool FijarTipoCambio { get; set; }

        public string OrigenPedido { get; set; }

        public string DescDirecEmbarque { get; set; }

        public string DivisionGeografica1 { get; set; }

        public string DivisionGeografica2 { get; set; }

        public decimal BaseImpuesto1 { get; set; }

        public decimal BaseImpuesto2 { get; set; }

        public string NombreCliente { get; set; }

        public DateTime FechaProyectada { get; set; }
        
        public DateTime FechaAprobacion { get; set; }
        
        public string TipoDocumento { get; set; }
        
        public string VersionCotizacion { get; set; }
        
        public string RazonCancelaCoti { get; set; }
        
        public string DesCancelaCoti { get; set; }
        
        public string CambiosCoti { get; set; }
        
        public string CotizacionPadre { get; set; }
        
        public string TasaImpositiva { get; set; }
        
        public decimal TasaImpositivaPorc { get; set; }
        
        public string TasaCree1 { get; set; }
        
        public decimal TasaCree1Porc { get; set; }
        
        public string TasaCree2 { get; set; }
        
        public decimal TasaCree2Porc { get; set; }
        
        public decimal TasaGanOcasionalPorc { get; set; }
        
        public string UsrNoAprueba { get; set; }
        
        public DateTime FechaNoAprueba { get; set; }
        
        public string RazonDesaprueba { get; set; }
        
        public string Modulo { get; set; }
        
        public string CorreosEnvio { get; set; }
        
        public string FormaPago { get; set; }
        
        public string ClaveReferenciaDE { get; set; }
        
        public DateTime FechaReferenciaDE { get; set; }  
        
        public string Incoterms { get; set; }
        
        public string UADWMNumeroVendedor { get; set; }
        
        public string UADWMEnviarGLN { get; set; }
        
        public string UADWMNumeroRecepcion { get; set; }
        
        public string UADWMNumeroReclamo { get; set; }
        
        public string UADWMFechaReclamo { get; set; }
        
        public string UADPCNumeroVendedor { get; set; }
        
        public string UADPCEnviarGLN { get; set; }
        
        public string UADGSNumeroVendedor { get; set; }
        
        public string UADGSEnviarGLN { get; set; }

        public string UADGSNumeroRecepcion { get; set; }

        public string UADGSFechaRecepcion { get; set; }

        public string UADAMNumeroProveedor { get; set; }

        public string UADAMEnviarGLN { get; set; }

        public string UADAMNumeroRecepcion { get; set; }

        public string UADAMNumeroReclamo { get; set; }

        public string UADAMFechaRecepcion { get; set; }

        public string TipoOperacion { get; set; }

        public string UADCCRemision { get; set; }

        public string UADCCFechaConsumo { get; set; }

        public string UADCCHojaEntrada { get; set; }

        public string ActividadComercial { get; set; }

        public decimal MontoOtroCargo { get; set; }

        public string CodigoReferenciaDE { get; set; }

        public string TipoReferenciaDE { get; set; }

        public bool TieneRelacionados { get; set; }

        public bool EsFacturaReemplazo { get; set; }

        public string FacturaOriginalReemplazo { get; set; }

        public string ConsecutivoFTC { get; set; }

        public string NITTransportador { get; set; }

        public string NumOCExenta { get; set; }

        public string NumConsRegExo { get; set; }

        public string NumIRSEdeAgrGan { get; set; }

        public string TipoPago { get; set; }

        public string TipoDescuentoGlobal { get; set; }

        public string TipoFactura { get; set; }
    }
}
