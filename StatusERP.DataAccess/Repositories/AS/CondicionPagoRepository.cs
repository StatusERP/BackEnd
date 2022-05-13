using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class CondicionPagoRepository:StatusERPContextBase<CondicionPago>,ICondicionPagoRepository
{
    public CondicionPagoRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<CondicionPago>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<CondicionPago>(page, rows);
    }

    public  async Task<CondicionPago?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<CondicionPago>(id);
    }

    public async Task<int> CreateAsync(CondicionPago condicionPago)
    {
        return await _dbContext.InsertAsync(condicionPago);
    }

    public async Task<int> UpdateAsync(CondicionPago condicionPago)
    {
        await _dbContext.UpdateAsync(condicionPago);
        return condicionPago.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new CondicionPago
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<CondicionPago?> BuscarCodCondicionPagoAsync(string codCondicionPago)
    {
        return await _dbContext.CondicionesPago
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodCondicionPago == codCondicionPago );
    }
}