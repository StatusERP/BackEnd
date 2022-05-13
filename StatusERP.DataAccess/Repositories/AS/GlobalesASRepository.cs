using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class GlobalesASRepository:StatusERPContextBase<GlobalesAS>,IGlobalesAsRepository
{
    public GlobalesASRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<GlobalesAS>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<GlobalesAS>(page, rows);
    }

    public async Task<GlobalesAS?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<GlobalesAS>(id);
    }

    public async Task<int> CreateAsync(GlobalesAS globalesAs)
    {
        return await _dbContext.InsertAsync(globalesAs);
    }

    public async Task<int> UpdateAsync(GlobalesAS globalesAs)
    {
        await _dbContext.UpdateAsync(globalesAs);
        return globalesAs.Id;

    }

    public async Task<ICollection<GlobalesAS>> GetAllAsync()
    {

        return await _dbContext.Set<GlobalesAS>()
               .Where(p => !p.IsDeleted)
               .AsNoTracking()
               .ToListAsync();
    }
}