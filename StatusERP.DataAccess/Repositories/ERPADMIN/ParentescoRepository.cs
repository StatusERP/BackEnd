using AutoMapper;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.DataAccess.Repositories.ERPADMIN;

public class ParentescoRepository:StatusERPContextBase<Parentesco> ,IParentescoRepository
{
    public ParentescoRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<Parentesco>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<Parentesco>(page, rows);
    }

    public async Task<Parentesco?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<Parentesco>(id);
    }

    public async Task<int> CreateAsync(Parentesco parentesco)
    {
        return await _dbContext.InsertAsync(parentesco);
    }

    public async Task<int> UpdateAsync(Parentesco parentesco)
    {
        await _dbContext.UpdateAsync(parentesco);
        return parentesco.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new Parentesco
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }
}