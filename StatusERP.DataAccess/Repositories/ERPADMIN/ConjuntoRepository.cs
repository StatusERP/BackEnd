using AutoMapper;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.DataAccess.Repositories.ERPADMIN;

public class ConjuntoRepository:StatusERPContextBase<Conjunto> ,IConjuntoRepository
{
    public ConjuntoRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<Conjunto>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<Conjunto>(page, rows);
    }

    public async Task<Conjunto?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<Conjunto>(id);
    }

    public async Task<int> CreateAsync(Conjunto conjunto)
    {
      
            return await _dbContext.InsertAsync(conjunto);
      
    }

    public  async Task<int> UpdateAsync(Conjunto conjunto)
    {
        await _dbContext.UpdateAsync(conjunto,Mapper);
        return conjunto.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new Conjunto
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }
}