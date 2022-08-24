using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.AS.Tablas;
using StatusERP.DataAccess.Repositories.AS.Interfaces;

namespace StatusERP.DataAccess.Repositories.AS;

public class PaisRepository : StatusERPContextBase<Pais>, IPaisRepository
{
    public PaisRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<Pais>> GetCollectionAsync()
    {
        return await _dbContext.Paises
        .Include(p => p.CCVentas)
        .Include(p => p.CCDescGral)
        .Include(p => p.CCCostoVen)
        .Include(p => p.CCDescLin)
        .Include(p => p.CCCostoLin)
        .Include(p => p.CCGasCom)
        .Include(p => p.CCContado)
        .Include(p => p.CCCC)
        .Include(p => p.CCLC)
        .Include(p => p.CCProntoPagoCC)
        .Include(p => p.CCIntMoraCC)
        .Include(p => p.CCRecibosCC)
        .Include(p => p.CCDebitoCC)
        .Include(p => p.CCCreditoCC)
        .Include(p => p.CCImpuesto1CC)
        .Include(p => p.CCImpuesto2CC)
        .Include(p => p.CCRubro1CC)
        .Include(p => p.CCRubro2CC)
        .Include(p => p.CCAnticipoCC)
        .Include(p => p.CCLP)
        .Include(p => p.CCCreditoCP)
        .Include(p => p.CCDebitoCP)
        .Include(p => p.CCCP)
        .Include(p => p.CCProntoPagoCP)
        .Include(p => p.CCComisionCP)
        .Include(p => p.CCImpuesto1CP)
        .Include(p => p.CCImpuesto2CP)
        .Include(p => p.CCRubro1CP)
        .Include(p => p.CCRubro2CP)
        .Include(p => p.CCAnticipoCP)
        .Include(p => p.CCDescBonif)
        .Include(p => p.CCDevVentas)
        .Include(p => p.CCIntCorriente)
        .Include(p => p.CCVentasExen)
        .Include(p => p.CCAjusteRedondeo)
        .Include(p => p.CCRentaCP)
        .Include(p => p.CCPensionONPCP)
        .Include(p => p.CCPensionAFPCP)
        .Include(p => p.CCComision)
        .Include(p => p.CCAdValorem)
        .Include(p => p.Direccion)
        .Include(p => p.Moneda)
        .Where(p => !p.IsDeleted)
        .AsNoTracking()
        .ToListAsync();
    }

    public async Task<Pais?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<Pais>(id);
    }

    public async Task<int> CreateAsync(Pais pais)
    {
        return await _dbContext.InsertAsync(pais);
    }

    public async Task<int> UpdateAsync(Pais pais)
    {

        try
        {
            var registro = await _dbContext.Set<Pais>()
        .AsNoTracking()
        .SingleOrDefaultAsync(x => x.Id == pais.Id && !x.IsDeleted);

            if (registro == null)
            {
                return 0;
            }

            registro.Id = pais.Id;
            registro.CodPais = pais.CodPais;
            registro.Nombre = pais.Nombre;
            registro.CodigoISO = pais.CodigoISO;
            registro.CtrCtaVentasId = pais.CtrCtaVentasId;
            registro.CtrCtaDescGralId = pais.CtrCtaDescGralId;
            registro.CtrCtaCostoVenId = pais.CtrCtaCostoVenId;
            registro.CtrCtaDescLinId = pais.CtrCtaDescLinId;
            registro.CtrCtaCostoLinId = pais.CtrCtaCostoLinId;
            registro.CtrCtaGasComId = pais.CtrCtaGasComId;
            registro.CtrCtaContadoId = pais.CtrCtaContadoId;
            registro.CtrCtaCCId = pais.CtrCtaCCId;
            registro.CtrCtaLCId = pais.CtrCtaLCId;
            registro.CtrCtaProntoPagoCCId = pais.CtrCtaProntoPagoCCId;
            registro.CtrCtaIntMoraCCId = pais.CtrCtaIntMoraCCId;
            registro.CtrCtaRecibosCCId = pais.CtrCtaRecibosCCId;
            registro.CtrCtaDebitoCCId = pais.CtrCtaDebitoCCId;
            registro.CtrCtaCreditoCCId = pais.CtrCtaCreditoCCId;
            registro.CtrCtaImpuesto1CCId = pais.CtrCtaImpuesto1CCId;
            registro.CtrCtaImpuesto2CCId = pais.CtrCtaImpuesto2CCId;
            registro.CtrCtaRubro1CCId = pais.CtrCtaRubro1CCId;
            registro.CtrCtaRubro2CCId = pais.CtrCtaRubro2CCId;
            registro.CtrCtaAnticipoCCId = pais.CtrCtaAnticipoCCId;
            registro.CtrCtaLPId = pais.CtrCtaLPId;
            registro.CtrCtaCreditoCPId = pais.CtrCtaCreditoCPId;
            registro.CtrCtaDebitoCPId = pais.CtrCtaDebitoCPId;
            registro.CtrCtaCPId = pais.CtrCtaCPId;
            registro.CtrCtaProntoPagoCPId = pais.CtrCtaProntoPagoCPId;
            registro.CtrCtaComisionCPId = pais.CtrCtaComisionCPId;
            registro.CtrCtaImpuesto1CPId = pais.CtrCtaImpuesto1CPId;
            registro.CtrCtaImpuesto2CPId = pais.CtrCtaImpuesto2CPId;
            registro.CtrCtaRubro1CPId = pais.CtrCtaRubro1CPId;
            registro.CtrCtaRubro2CPId = pais.CtrCtaRubro2CPId;
            registro.CtrCtaAnticipoCPId = pais.CtrCtaAnticipoCPId;
            registro.CtrCtaDescBonifId = pais.CtrCtaDescBonifId;
            registro.CtrCtaDevVentasId = pais.CtrCtaDevVentasId;
            registro.CtrCtaIntCorrienteId = pais.CtrCtaIntCorrienteId;
            registro.CtrCtaVentasExenId = pais.CtrCtaVentasExenId;
            registro.CtrCtaAjusteRedondeoId = pais.CtrCtaAjusteRedondeoId;
            registro.CtrCtaRentaCPId = pais.CtrCtaRentaCPId;
            registro.CtrCtaPensionONPCPId = pais.CtrCtaPensionONPCPId;
            registro.CtrCtaPensionAFPCPId = pais.CtrCtaPensionAFPCPId;
            registro.CtrCtaComisionId = pais.CtrCtaComisionId;
            registro.CtrCtaAdValoremId = pais.CtrCtaAdValoremId;
            registro.DireccionId = pais.DireccionId;
            registro.EtiquetaDivGeo1 = pais.EtiquetaDivGeo1;
            registro.EtiquetaDivGeo2 = pais.EtiquetaDivGeo2;
            registro.MonedaId = pais.MonedaId;
            registro.IsDeleted = registro.IsDeleted;
            registro.Updatedby = pais.Updatedby;
            registro.UpdateDate = pais.UpdateDate;
            registro.Createdby = registro.Createdby;
            registro.CreateDate = registro.CreateDate;

            _dbContext.Set<Pais>().Attach(registro);
            _dbContext.Entry(registro).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        catch (Exception ex)
        {
            Console.Write(ex);
        }

        return pais.Id;

    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new Pais
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<Pais?> BuscarCodPaisAsync(string codPais)
    {
        return await _dbContext.Paises
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodPais == codPais);
    }
}