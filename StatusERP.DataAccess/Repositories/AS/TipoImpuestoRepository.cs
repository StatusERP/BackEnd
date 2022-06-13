using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class TipoImpuestoRepository : StatusERPContextBase<TipoImpuesto>, ITipoImpuestoRepository
{
    public TipoImpuestoRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<TipoImpuesto>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<TipoImpuesto>(page, rows);
    }

    public async Task<TipoImpuesto?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<TipoImpuesto>(id);
    }

    public async Task<int> CreateAsync(TipoImpuesto tipoImpuesto)
    {
        return await _dbContext.InsertAsync(tipoImpuesto);
    }

    public async Task<int> UpdateAsync(TipoImpuesto tipoImpuesto)
    {
        await _dbContext.UpdateAsync(tipoImpuesto,Mapper);
        return tipoImpuesto.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new TipoImpuesto
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<TipoImpuesto?> BuscarCodTipoImpuestoAsync(string codTipoImpuesto)
    {
        return await _dbContext.TiposImpuesto 
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodTipoImpuesto == codTipoImpuesto);
    }
}