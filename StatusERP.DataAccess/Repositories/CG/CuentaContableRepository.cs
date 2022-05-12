using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public class CuentaContableRepository : StatusERPContextBase<CuentaContable>, ICuentaContableRepository
    {

        public CuentaContableRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<CuentaContable?> BuscarCodCuentaContableAsync(string CodCuentaContable)
        {
            return await _dbContext.CuentasContables
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodCuentaContable == CodCuentaContable);
        }

        public async Task<int> CreateAsync(CuentaContable CuentaContable)
        {
            return await _dbContext.InsertAsync(CuentaContable);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new CuentaContable
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<CuentaContable?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<CuentaContable>(id);
        }

        public async Task<ICollection<CuentaContable>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<CuentaContable>(page, rows);
        }

        public async Task<int> UpdateAsync(CuentaContable CuentaContable)
        {
            await _dbContext.UpdateAsync(CuentaContable);
            return CuentaContable.Id;
        }
    }
}
