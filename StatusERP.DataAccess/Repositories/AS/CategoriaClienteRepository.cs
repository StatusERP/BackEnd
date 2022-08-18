using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class CategoriaClienteRepository : StatusERPContextBase<CategoriaCliente>, ICategoriaClienteRepository
{
    public CategoriaClienteRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }


    public async Task<ICollection<CategoriaCliente>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<CategoriaCliente>(page, rows);
    }

    public async Task<CategoriaCliente?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<CategoriaCliente>(id);
    }

    public async Task<CategoriaCliente?> BuscarCodCategoriaClienteAsync(string codCategoriaCliente)
    {

        return await _dbContext.CategoriasCliente
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodCategoriaCliente == codCategoriaCliente);
    }


    public async Task<int> CreateAsync(CategoriaCliente categoriaCliente)
    {
        return await _dbContext.InsertAsync(categoriaCliente);
    }


    public async Task<int> UpdateAsync(CategoriaCliente categoriaCliente)
    {

        try
        {
            var registro = await _dbContext.Set<CategoriaCliente>()
           .AsNoTracking()
           .SingleOrDefaultAsync(x => x.Id == categoriaCliente.Id && !x.IsDeleted);

            if (registro == null)
            {
                return 0;
            }
            registro.Id = categoriaCliente.Id;
            registro.CodCategoriaCliente = categoriaCliente.CodCategoriaCliente;
            registro.Descripcion = categoriaCliente.Descripcion;
            registro.CtrCtaVentasId = categoriaCliente.CtrCtaDevVentasId;
            registro.CtrCtaDescGralId = categoriaCliente.CtrCtaDescGralId;
            registro.CtrCtaCostVentId = categoriaCliente.CtrCtaCostVentId;
            registro.CtrCtaDescLinId = categoriaCliente.CtrCtaDescLinId;
            registro.CtrCtaCostLinId = categoriaCliente.CtrCtaCostLinId;
            registro.CtrCtaVendComId = categoriaCliente.CtrCtaVendComId;
            registro.CtrCtaCobrComId = categoriaCliente.CtrCtaCobrComId;
            registro.CtrCtaCCId = categoriaCliente.CtrCtaCCId;
            registro.CtrCtaLCId = categoriaCliente.CtrCtaLCId;
            registro.CtrCtaContadoId = categoriaCliente.CtrCtaContadoId;
            registro.CtrCtaProntoPagoCCId = categoriaCliente.CtrCtaProntoPagoCCId;
            registro.CtrCtaIntMoraCCId = categoriaCliente.CtrCtaIntMoraCCId;
            registro.CtrCtaRecibosCCId = categoriaCliente.CtrCtaRecibosCCId;
            registro.CtrCtaDebitoCCId = categoriaCliente.CtrCtaDebitoCCId;
            registro.CtrCtaCreditoCCId = categoriaCliente.CtrCtaCreditoCCId;
            registro.CtrCtaImpuesto1CCId = categoriaCliente.CtrCtaImpuesto1CCId;
            registro.CtrCtaImpuesto2CCId = categoriaCliente.CtrCtaImpuesto2CCId;
            registro.CtrCtaRubro1CCId = categoriaCliente.CtrCtaRubro1CCId;
            registro.CtrCtaRubro2CCId = categoriaCliente.CtrCtaRubro2CCId;
            registro.CtrCtaAnticipoCCId = categoriaCliente.CtrCtaAnticipoCCId;
            registro.CtrCtaDescBonifId = categoriaCliente.CtrCtaDescBonifId;
            registro.CtrCtaDevVentasId = categoriaCliente.CtrCtaDevVentasId;
            registro.CtrCtaIntCorrId = categoriaCliente.CtrCtaIntCorrId;
            registro.CtrCtaVentasExenId = categoriaCliente.CtrCtaVentasExenId;
            registro.CtrCtaAjusteRedondeoId = categoriaCliente.CtrCtaAjusteRedondeoId;
            registro.IsDeleted = registro.IsDeleted;
            registro.Createdby = registro.Createdby;
            registro.CreateDate = registro.CreateDate;
            registro.Updatedby = categoriaCliente.Updatedby;
            registro.UpdateDate = categoriaCliente.UpdateDate;


            _dbContext.Set<CategoriaCliente>().Attach(registro);
            _dbContext.Entry(registro).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

        }
        catch (Exception ex)
        {
            Console.Write(ex);
        }

        return categoriaCliente.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new CategoriaCliente
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }
}