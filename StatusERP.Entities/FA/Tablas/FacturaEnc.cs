using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StatusERP.Entities.FA.Tablas
{
    [Table("FacturaEncs", Schema = Constants.Conjunto)]
    public class FacturaEnc:EntityBase
    {
        public string TipoDocumento { get; set; }
        
        public string Factura { get; set; }
        
        public int MovInventarioEncId { get; set; }
        
        public bool EstaDespachado { get; set; }
        
        public bool EnInvestigacion { get; set; }
        
        public bool TransAdicionales { get; set; }
        
        public string EstadoRemision { get; set; }

        public string AsientoDocumento { get; set; }

        public decimal DescuentoVolumen { get; set; }

        public string MonedaFactura { get; set; }

        public string ComentarioCXC { get; set; }

        public DateTime FechaDespacho { get; set; }

        public string ClaseDocumento { get; set; }

        public DateTime FechaRecibido { get; set; }

        public string Pedido { get; set; }

        public string FacturaOriginal { get; set; }

        public string TipoOriginal { get; set; }

        public decimal ComisionCobrador { get; set; }

        public string TarjetaCredito { get; set; }

        public decimal TotalVolumen { get; set; }

        public string NumeroAutoriza { get; set; }

        public decimal TotalPeso { get; set; }

        public decimal MontoCobrado { get; set; }

        public decimal TotalImpuesto1 { get; set; }

        public DateTime Fecha { get; set; }




        public DateTime FechaEntrega { get; set; }

        public decimal TotalImpuesto2 { get; set; }

        public decimal PorDescuento2 { get; set; }

        public decimal MontoFlete { get; set; }

        public decimal MontoSeguro { get; set; }

        public decimal MontoDocumentacio { get; set; }

        public string TipoDescuento1 {get; set;}
        
        public string TipoDescuento2 {get; set;}

        public decimal PorcDescuento1 { get; set; }

        public decimal TotalFactura { get; set; }

        public DateTime FechaPedido { get; set; }

        public DateTime FechaHoraAnula { get; set; }

        public DateTime FechaOrden { get; set; }

        public decimal TotalMercaderia { get; set; }

        public decimal ComisionVendedor { get; set; }

        public string OrdenCompra { get; set; }

        public DateTime FechaHora { get; set; }

        public decimal TotalUnidades { get; set; }

        public Int16 NumeroPaginas { get; set; }

        public decimal TipoCambio { get; set; }

        public bool Anulada { get; set; }

        public string Modulo { get; set; }

        public bool CargadoCG { get; set; }




        public bool CargadoCXC { get; set; }

        public string EmbarcarA { get; set; }

        public string DirecEmbarque { get; set; }

        public Int16 MultiplicadorEV { get; set; }

        public string Observaciones { get; set; } 

        [StringLength(50)]
        public string ? Rubro1 { get; set; }

        [StringLength(50)]
        public string? Rubro2 { get; set; }

        [StringLength(50)]
        public string? Rubro3 { get; set; }

        [StringLength(50)]
        public string? Rubro4 { get; set; }

        [StringLength(50)]
        public string? Rubro5 { get; set; }

        public int VersionNP { get; set; }

        public string Moneda { get; set; }

        public string NivelPrecio { get; set; }

        public string Cobrador { get; set; }

        public string Ruta { get; set; }

        [StringLength(450)]
        public string Usuario { get; set; }

        [StringLength(450)]
        public string UsuarioAnula { get; set; }

        [StringLength(4)]
        public string CondicionPago { get; set; }

        public int Zona { get; set; }

        public int Vendedor { get; set; }

        [StringLength(50)]
        public string DocCreditoCXC { get; set; }

        [StringLength(20)]
        public string ClienteDireccion { get; set; }

        [StringLength(20)]
        public string ClienteCorporac { get; set; }

        [StringLength(20)]
        public string ClienteOrigen { get; set; }

        public int Cliente { get; set; }







        public int Pais { get; set; }

        public Int16 SubTipoDocCXC { get; set; }

        public string TipoCreditoCXC { get; set; }

        public string TipoDocCXC { get; set; }

        public decimal MontoAnticipo { get; set; }

        public decimal TotalPesoNeto { get; set; }

        public DateTime FechaRige { get; set; }

        public decimal PorcIntCte { get; set; }

        public bool Cobrada { get; set; }

        public bool DescuentoCascada { get; set; }

        public string DireccionFactura { get; set; }

        public string DireccionEmbarque { get; set; }

        public string Consecutivo { get; set; }

        public bool Reimpreso { get; set; }

        [StringLength(12)]
        public string ? DivisionGeografica1 { get; set; }

        [StringLength(12)]
        public string? DivisionGeografica2 { get; set; }

        public decimal? BaseImpuesto1 { get; set; }

        public decimal? BaseImpuesto2 { get; set; }

        public string? NombreCliente { get; set; }

        public string DocFiscal { get; set; }









    }
}
