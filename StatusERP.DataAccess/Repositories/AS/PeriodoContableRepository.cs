using AutoMapper;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class PeriodoContableRepository:StatusERPContextBase<PeriodoContable>,IPeriodosContableRepository
{
    public PeriodoContableRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<PeriodoContable>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<PeriodoContable>(page, rows);
    }

    public async Task<PeriodoContable?> GetByIdAsync(int id)
    {  
        return await _dbContext.SelectAsync<PeriodoContable>(id);
    }

    public async Task<int> CreateAsync(PeriodoContable periodoContable)
    {
        return await _dbContext.InsertAsync(periodoContable);
    }

    public async Task<int> UpdateAsync(PeriodoContable periodoContable)
    {
        await _dbContext.UpdateAsync(periodoContable);
        return periodoContable.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new PeriodoContable
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }
}