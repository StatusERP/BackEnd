using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class TipoCambioRepository:StatusERPContextBase<TipoCambio>,ITipoCambioRepository
{
    public TipoCambioRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<TipoCambio>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<TipoCambio>(page, rows);
    }

    public async Task<TipoCambio?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<TipoCambio>(id);
    }

    public async Task<int> CreateAsync(TipoCambio tipoCambio)
    {
        return await _dbContext.InsertAsync(tipoCambio);
    }

    public async Task<int> UpdateAsync(TipoCambio tipoCambio)
    {
        await _dbContext.UpdateAsync(tipoCambio);
        return tipoCambio.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new TipoCambio
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<TipoCambio?> BuscarCodTipoCambioAsync(string codTipoCambio)
    {
        return await _dbContext.TiposCambio
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodTipoCambio == codTipoCambio );
    }
}