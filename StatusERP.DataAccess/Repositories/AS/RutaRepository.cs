using AutoMapper;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class RutaRepository:StatusERPContextBase<Ruta>,IRutaRepository
{
    public RutaRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<Ruta>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<Ruta>(page, rows);
    }

    public  async Task<Ruta?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<Ruta>(id);
    }

    public async Task<int> CreateAsync(Ruta ruta)
    {
        return await _dbContext.InsertAsync(ruta);
    }

    public async Task<int> UpdateAsync(Ruta ruta)
    {
        await _dbContext.UpdateAsync(ruta, Mapper);
        return ruta.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new Ruta
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }
}