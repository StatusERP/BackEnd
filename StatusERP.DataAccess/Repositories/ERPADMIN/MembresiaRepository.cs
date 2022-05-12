using AutoMapper;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.DataAccess.Repositories.ERPADMIN;

public class MembresiaRepository : StatusERPContextBase<Membresia>,IMembresiaRepository
{
    public MembresiaRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<Membresia>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<Membresia>(page, rows);
    }

    public async Task<Membresia?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<Membresia>(id);
    }

    public async Task<int> CreateAsync(Membresia membresia)
    {
        return await _dbContext.InsertAsync(membresia); 
    }

    public async Task<int> UpdateAsync(Membresia membresia)
    {
        await _dbContext.UpdateAsync(membresia);
        return membresia.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new Membresia
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }
}