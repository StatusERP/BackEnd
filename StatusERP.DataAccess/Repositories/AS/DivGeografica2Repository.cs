using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class DivGeografica2Repository : StatusERPContextBase<DivGeografica2> ,IDivGeografica2Repository
{
    public DivGeografica2Repository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<DivGeografica2>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<DivGeografica2>(page, rows);
    }

    public async Task<DivGeografica2?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<DivGeografica2>(id);
    }

    public async Task<int> CreateAsync(DivGeografica2 divGeografica2)
    {
        return await _dbContext.InsertAsync(divGeografica2);
    }

    public async Task<int> UpdateAsync(DivGeografica2 divGeografica2)
    {
        await _dbContext.UpdateAsync(divGeografica2,Mapper);
        return divGeografica2.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new DivGeografica2
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<DivGeografica2?> BuscarCodDivGeografica2Async(string codDivGeografica)
    {
        return await _dbContext.DivGeograficas2
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodDivGeografica2 == codDivGeografica );
    }
}