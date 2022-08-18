using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.FA.Interfaces;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Repositories.FA
{
    public class GlobalesFARepository : StatusERPContextBase<GlobalesFA>, IGlobalesFARepository
    {

        public GlobalesFARepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }


        public async Task<int> CreateAsync(GlobalesFA globalesFA)
        {
            return await _dbContext.InsertAsync(globalesFA);
        }


        public async Task<int> UpdateAsync(GlobalesFA globalesFA)
        {
            //await _dbContext.UpdateAsync(globalesFA, Mapper);
            //return globalesFA.Id;

            try
            {
                var registro = await _dbContext.Set<GlobalesFA>()
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == globalesFA.Id && !x.IsDeleted);

                if (registro == null)
                {
                    return 0;
                }

                registro.BodegaDefaultId = globalesFA.BodegaDefaultId;
                registro.CondPagoContadoId = globalesFA.CondPagoContadoId;
                registro.VendedorObligator = globalesFA.VendedorObligator;
                registro.FactExcPedido = globalesFA.FactExcPedido;
                registro.UsaTarjetaCred = globalesFA.UsaTarjetaCred;
                registro.BodegaPorLinea = globalesFA.BodegaPorLinea;
                registro.PermiteBackorder = globalesFA.PermiteBackorder;
                registro.CancelPedParcial = globalesFA.CancelPedParcial;
                registro.PedAImpresora = globalesFA.PedAImpresora;
                registro.DocAImpresora = globalesFA.DocAImpresora;
                registro.ImpreLoteSeparad = globalesFA.ImpreLoteSeparad;
                registro.FacturaMultipag = globalesFA.FacturaMultipag;
                registro.NCRNumFactura = globalesFA.NCRNumFactura;
                registro.MultipleFMTFactu = globalesFA.MultipleFMTFactu;
                registro.MultipleFMTPedid = globalesFA.MultipleFMTPedid;
                registro.OrdenLineasFact = globalesFA.OrdenLineasFact;
                registro.ReimpresionPedido = globalesFA.ReimpresionPedido;
                registro.ImpPedidoAlFact = globalesFA.ImpPedidoAlFact;
                registro.RedondearFactura = globalesFA.RedondearFactura;
                registro.FactorRedondeo = globalesFA.FactorRedondeo;
                registro.PreciosDec = globalesFA.PreciosDec;
                registro.DescEnPrecio = globalesFA.DescEnPrecio;
                registro.Imp1EnPrecio = globalesFA.Imp1EnPrecio;
                registro.Imp1AfectaDescto = globalesFA.Imp1AfectaDescto;
                registro.AplicaNiPrImp1 = globalesFA.AplicaNiPrImp1;
                registro.NivelPrecioImp1Id = globalesFA.NivelPrecioImp1Id;
                registro.PagoComParcial = globalesFA.PagoComParcial;
                registro.PorcImpComision = globalesFA.PorcImpComision;
                registro.AsientoVentaPor = globalesFA.AsientoVentaPor;
                registro.TipoPartidaId = globalesFA.TipoPartidaId;
                registro.PaqueteId = globalesFA.PaqueteId;
                registro.CtrCtaFleteId = globalesFA.CtrCtaFleteId;
                registro.CtrCtaSeguroId = globalesFA.CtrCtaSeguroId;
                registro.CtrCtaDocumentacionId = globalesFA.CtrCtaDocumentacionId;
                registro.CtrCtaImpuesto1Id = globalesFA.CtrCtaImpuesto1Id;
                registro.CtrCtaImpuesto2Id = globalesFA.CtrCtaImpuesto2Id;
                registro.CtrCtaImpComisioId = globalesFA.CtrCtaImpComisioId;
                registro.UsarRubros = globalesFA.UsarRubros;
                registro.Rubro1Nombre = globalesFA.Rubro1Nombre;
                registro.Rubro2Nombre = globalesFA.Rubro2Nombre;
                registro.Rubro3Nombre = globalesFA.Rubro3Nombre;
                registro.Rubro4Nombre = globalesFA.Rubro4Nombre;
                registro.UsaBoletas = globalesFA.UsaBoletas;
                registro.NomRubro6Cli = globalesFA.NomRubro6Cli;
                registro.NomRubro7Cli = globalesFA.NomRubro7Cli;
                registro.NomRubro8Cli = globalesFA.NomRubro8Cli;
                registro.NomRubro9Cli = globalesFA.NomRubro9Cli;
                registro.Rubro5Nombre = globalesFA.Rubro5Nombre;
                registro.Observaciones = globalesFA.Observaciones;
                registro.NivelPrecioPublicoId = globalesFA.NivelPrecioPublicoId;
                registro.ColumnasEstandar = globalesFA.ColumnasEstandar;
                registro.AsientoCostoPor = globalesFA.AsientoCostoPor;
                registro.CambiarEsqTrab = globalesFA.CambiarEsqTrab;
                registro.FactDocsVencidos = globalesFA.FactDocsVencidos;
                registro.FactCobroJud = globalesFA.FactCobroJud;
                registro.FactLimiteCred = globalesFA.FactLimiteCred;
                registro.ModAplicAsiento = globalesFA.ModAplicAsiento;
                registro.IntegracionConta = globalesFA.IntegracionConta;
                registro.TipoContaOmision = globalesFA.TipoContaOmision;
                registro.TipoCambioId = globalesFA.TipoCambioId;
                registro.PrecisionMaxima = globalesFA.PrecisionMaxima;
                registro.LineasArticulo = globalesFA.LineasArticulo;
                registro.LineasFactura = globalesFA.LineasFactura;
                registro.LineasAdicionales = globalesFA.LineasAdicionales;
                registro.DetalleKits = globalesFA.DetalleKits;
                registro.MonedaPrecios = globalesFA.MonedaPrecios;
                registro.Prevista1 = globalesFA.Prevista1;
                registro.Prevista2 = globalesFA.Prevista2;
                registro.Prevista3 = globalesFA.Prevista3;
                registro.Prevista4 = globalesFA.Prevista4;
                registro.Prevista5 = globalesFA.Prevista5;
                registro.CtrConsumoId = globalesFA.CtrConsumoId;
                registro.CCEnLinea = globalesFA.CCEnLinea;
                registro.CGEnLinea = globalesFA.CGEnLinea;
                registro.UsarAutorizacion = globalesFA.UsarAutorizacion;
                registro.Imp1EnBonifica = globalesFA.Imp1EnBonifica;
                registro.Imp2EnBonifica = globalesFA.Imp2EnBonifica;
                registro.AsientoContCXCPor = globalesFA.AsientoContCXCPor;
                registro.UsarAprobPedidos = globalesFA.UsarAprobPedidos;
                registro.NomRubro10Cli = globalesFA.NomRubro10Cli;
                registro.ListaPrecios = globalesFA.ListaPrecios;
                registro.MargenUtilidad = globalesFA.MargenUtilidad;
                registro.MontoMinimo = globalesFA.MontoMinimo;
                registro.DocVencidos = globalesFA.DocVencidos;
                registro.LimiteCredito = globalesFA.LimiteCredito;
                registro.CobroJudicial = globalesFA.CobroJudicial;
                registro.SinOC = globalesFA.SinOC;
                registro.DiasAtraso = globalesFA.DiasAtraso;
                registro.MontoMinimoLocal = globalesFA.MontoMinimoLocal;
                registro.MontoMinimoDolar = globalesFA.MontoMinimoDolar;
                registro.SaldoMaxLocal = globalesFA.SaldoMaxLocal;
                registro.SaldoMaxDolar = globalesFA.SaldoMaxDolar;
                registro.MaxDiasAtraso = globalesFA.MaxDiasAtraso;
                registro.MaxDocsVenc = globalesFA.MaxDocsVenc;
                registro.PreciosDecDolar = globalesFA.PreciosDecDolar;
                registro.CondPagoNivPre = globalesFA.CondPagoNivPre;
                registro.FactListaPrecios = globalesFA.FactListaPrecios;
                registro.FactMargenUtilid = globalesFA.FactMargenUtilid;
                registro.FactMontoMinimo = globalesFA.FactMontoMinimo;
                registro.FactDiasAtraso = globalesFA.FactDiasAtraso;
                registro.FactSinOC = globalesFA.FactSinOC;
                registro.UsarRubrosVal = globalesFA.UsarRubrosVal;
                registro.ImpDescClasific = globalesFA.ImpDescClasific;
                registro.LimitarMaxLineas = globalesFA.LimitarMaxLineas;
                registro.IndicadPedido = globalesFA.IndicadPedido;
                registro.PrecioCosto = globalesFA.PrecioCosto;
                registro.FactMenorReserva = globalesFA.FactMenorReserva;
                registro.AnulaCXCAplicado = globalesFA.AnulaCXCAplicado;
                registro.TipoCostoNoExist = globalesFA.TipoCostoNoExist;
                registro.CalculoImp2 = globalesFA.CalculoImp2;
                registro.CategoriaClienteId = globalesFA.CategoriaClienteId;
                registro.NivelPrecioId = globalesFA.NivelPrecioId;
                registro.DescuentoCascada = globalesFA.DescuentoCascada;
                registro.Retenciones = globalesFA.Retenciones;
                registro.RetencionesFletes = globalesFA.RetencionesFletes;
                registro.ArticuloId = globalesFA.ArticuloId;
                registro.CodigoRetencion = globalesFA.CodigoRetencion;
                registro.AplicarDescGen = globalesFA.AplicarDescGen;
                registro.ModoDescMult = globalesFA.ModoDescMult;
                registro.DctoGeneral = globalesFA.DctoGeneral;
                registro.FactDctoGeneral = globalesFA.FactDctoGeneral;
                registro.AutorGrabar = globalesFA.AutorGrabar;
                registro.AutorAprobar = globalesFA.AutorAprobar;
                registro.AutorFactuRemitir = globalesFA.AutorFactuRemitir;
                registro.AutorFactRemision = globalesFA.AutorFactRemision;
                registro.CargarAprobadoCC = globalesFA.CargarAprobadoCC;
                registro.RemisionAImpres = globalesFA.RemisionAImpres;
                registro.DevolucAImpres = globalesFA.DevolucAImpres;
                registro.NomRubro16Cli = globalesFA.NomRubro16Cli;
                registro.NomRubro17Cli = globalesFA.NomRubro17Cli;
                registro.NomRubro18Cli = globalesFA.NomRubro18Cli;
                registro.NomRubro19Cli = globalesFA.NomRubro19Cli;
                registro.NomRubro20Cli = globalesFA.NomRubro20Cli;
                registro.CreaNuevoCliente = globalesFA.CreaNuevoCliente;
                registro.IsDeleted = registro.IsDeleted;
                registro.Updatedby = registro.Updatedby;
                registro.UpdateDate = registro.UpdateDate;
                registro.Createdby = registro.Createdby;
                registro.CreateDate = registro.CreateDate;

                _dbContext.Set<GlobalesFA>().Attach(registro);
                _dbContext.Entry(registro).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }

            return globalesFA.Id;
        }

        public async Task<ICollection<GlobalesFA>> GetAllAsync()
        {

            return await _dbContext.Set<GlobalesFA>()
                   .Where(p => !p.IsDeleted)
                   .AsNoTracking()
                   .ToListAsync();
        }
    }
}