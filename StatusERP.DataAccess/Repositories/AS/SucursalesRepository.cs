using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class SucursalesRepository:StatusERPContextBase<Sucursal> ,ISucursalesRepository
{
    public SucursalesRepository(StatusERPDBContext context,IMapper mapper) :base(context,mapper)
    {
            
    }
    public async Task<ICollection<Sucursal>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<Sucursal>(page, rows);
    }

    public async Task<Sucursal?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<Sucursal>(id);
    }

    public async Task<Sucursal?> BuscarCodSucursalAsync(string codSucursal)
    {
        return await _dbContext.Sucursales
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodSucursal == codSucursal );
    }


    public async Task<int> CreateAsync(Sucursal sucursal)
    {
        return await _dbContext.InsertAsync(sucursal);
    }

  
    public async Task<int> UpdateAsync(Sucursal sucursal)
    {
        await _dbContext.UpdateAsync(sucursal,Mapper);
        return sucursal.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new Sucursal
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }
}