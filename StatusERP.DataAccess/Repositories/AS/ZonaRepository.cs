using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.AS.Tablas;
using StatusERP.DataAccess.Repositories.AS.Interfaces;

namespace StatusERP.DataAccess.Repositories.AS;

public class ZonaRepository :StatusERPContextBase<Zona> ,IZonaRepository
{
    public ZonaRepository(StatusERPDBContext context,IMapper mapper) :base(context, mapper)
    {
        
    }

    public async Task<ICollection<Zona>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<Zona>(page, rows);
    }

    public async Task<Zona?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<Zona>(id);
    }

    public async Task<Zona?> BuscarCodZonaAsync(string codZona)
    {
        return await _dbContext.Zonas
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodZona == codZona );
    }

    public  async Task<int> CreateAsync(Zona zona)
    {
        return await _dbContext.InsertAsync(zona);
    }

    public async Task<int> UpdateAsync(Zona zona)
    {
        await _dbContext.UpdateAsync(zona);
        return zona.Id;

    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new Zona
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }
}