using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public class SaldoCuentaRepository : StatusERPContextBase<SaldoCuenta>, ISaldoCuentaRepository
    {

        public SaldoCuentaRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<int> CreateAsync(SaldoCuenta SaldoCuenta)
        {
            return await _dbContext.InsertAsync(SaldoCuenta);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new SaldoCuenta
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<SaldoCuenta?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<SaldoCuenta>(id);
        }

        public async Task<ICollection<SaldoCuenta>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<SaldoCuenta>(page, rows);
        }

        public async Task<int> UpdateAsync(SaldoCuenta SaldoCuenta)
        {
            await _dbContext.UpdateAsync(SaldoCuenta,Mapper);
            return SaldoCuenta.Id;
        }
    }
}
