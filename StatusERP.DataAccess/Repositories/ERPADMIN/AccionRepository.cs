using AutoMapper;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.DataAccess.Repositories.ERPADMIN;

public class AccionRepository:StatusERPContextBase<Accion>,IAccionRepository
{
    public AccionRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<Accion>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<Accion>(page, rows);
    }

    public async Task<Accion?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<Accion>(id);
    }

    public async Task<int> CreateAsync(Accion accion)
    {
        return await _dbContext.InsertAsync(accion);
    }

    public async Task<int> UpdateAsync(Accion accion)
    {
        await _dbContext.UpdateAsync(accion);
        return accion.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new Accion
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }
}