using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class DivGeografica1Repository :StatusERPContextBase<DivGeografica1>,IDivGeografica1Repository
{
    public DivGeografica1Repository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<DivGeografica1>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<DivGeografica1>(page, rows);
    }

    public async Task<DivGeografica1?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<DivGeografica1>(id);
    }

    public  async Task<int> CreateAsync(DivGeografica1 divGeografica1)
    { return await _dbContext.InsertAsync(divGeografica1); throw new NotImplementedException();
    }

    public async Task<int> UpdateAsync(DivGeografica1 divGeografica1)
    {
        await _dbContext.UpdateAsync(divGeografica1);
        return divGeografica1.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new DivGeografica1
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<DivGeografica1?> BuscarCodDivGeografica1Async(string codDivGeografica)
    {
        return await _dbContext.DivGeograficas1
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodDivGeografica1 == codDivGeografica );
    }
}