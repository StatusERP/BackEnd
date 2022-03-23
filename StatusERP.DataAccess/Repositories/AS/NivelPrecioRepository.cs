using AutoMapper;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class NivelPrecioRepository:StatusERPContextBase<NivelPrecio>,INivelPrecioRepository
{
    public NivelPrecioRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<NivelPrecio>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<NivelPrecio>(page, rows);
    }

    public async Task<NivelPrecio?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<NivelPrecio>(id);
    }

    public async Task<int> CreateAsync(NivelPrecio nivelPrecio)
    {
        return await _dbContext.InsertAsync(nivelPrecio);
    }

    public async Task<int> UpdateAsync(NivelPrecio nivelPrecio)
    {
        await _dbContext.UpdateAsync(nivelPrecio,Mapper);
        return nivelPrecio.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new NivelPrecio
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }
}