using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class BodegaRepository:StatusERPContextBase<Bodega>,IBodegaRepository
{
    public BodegaRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<Bodega>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<Bodega>(page, rows);
    }

    public  async Task<Bodega?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<Bodega>(id);
    }
    
    public  async Task<Bodega?> BuscarCodBodegaAsync(string codBodega)
    {
       
        return await _dbContext.Bodegas
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodBodega == codBodega );
    }

    
    public async Task<int> CreateAsync(Bodega bodega)
    {
        return await _dbContext.InsertAsync(bodega);
    }

    

    public async Task<int> UpdateAsync(Bodega bodega)
    {
        await _dbContext.UpdateAsync(bodega, Mapper);
        return bodega.Id;
    }

    public  async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new Bodega
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }
}