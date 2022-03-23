using AutoMapper;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class ModenaRepository: StatusERPContextBase<Moneda>, IMonedaRepository
{
    public ModenaRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<Moneda>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<Moneda>(page, rows);
    }

    public async Task<Moneda?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<Moneda>(id);
    }

    public async Task<int> CreateAsync(Moneda moneda)
    { return await _dbContext.InsertAsync(moneda);
        
    }

    public async Task<int> UpdateAsync(Moneda moneda)
    {
        await _dbContext.UpdateAsync(moneda,Mapper);
        return moneda.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new Moneda
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }
}