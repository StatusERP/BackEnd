using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class EntidadFinacieraRepository:StatusERPContextBase<EntidadFinanciera>,IEntidadFinacieraRepository
{
    public EntidadFinacieraRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<EntidadFinanciera>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<EntidadFinanciera>(page, rows);
    }

    public async Task<EntidadFinanciera?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<EntidadFinanciera>(id);
    }

    public async Task<int> CreateAsync(EntidadFinanciera entidadFinanciera)
    {
        return await _dbContext.InsertAsync(entidadFinanciera);
    }

    public async Task<int> UpdateAsync(EntidadFinanciera entidadFinanciera)
    {
        await _dbContext.UpdateAsync(entidadFinanciera);
        return entidadFinanciera.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new EntidadFinanciera
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<EntidadFinanciera?> BuscarCodEntidadFinacieraAsync(string codEntFinaciera)
    {
        return await _dbContext.EntidadesFinancieras
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodEntidadFinanciera == codEntFinaciera );
    }
}