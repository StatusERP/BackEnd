using AutoMapper;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class ConsecutivoGlobalRepository:StatusERPContextBase<ConsecutivoGlobal>,IConsecutivoGlobalRepository
{
    public ConsecutivoGlobalRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<ConsecutivoGlobal>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<ConsecutivoGlobal>(page, rows);
    }

    public async Task<ConsecutivoGlobal?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<ConsecutivoGlobal>(id);
    }

    public  async Task<int> CreateAsync(ConsecutivoGlobal consecutivoGlobal)
    {
        return await _dbContext.InsertAsync(consecutivoGlobal);
    }

    public async Task<int> UpdateAsync(ConsecutivoGlobal consecutivoGlobal)
    {
        await _dbContext.UpdateAsync(consecutivoGlobal, Mapper);
        return consecutivoGlobal.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new ConsecutivoGlobal
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }
}