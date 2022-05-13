using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public class CentroCuentaRepository : StatusERPContextBase<CentroCuenta>, ICentroCuentaRepository
    {

        public CentroCuentaRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<CentroCuenta?> BuscarCodCentroCuentaAsync(int CentroCostoId, int CentroCuentaId)
        {
            return await _dbContext.CentroCuenta
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CentroCostoId == CentroCostoId && t.CuentaContableId == CentroCuentaId);
        }

        public async Task<int> CreateAsync(CentroCuenta CentroCuenta)
        {
            return await _dbContext.InsertAsync(CentroCuenta);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new CentroCuenta
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<CentroCuenta?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<CentroCuenta>(id);
        }

        public async Task<ICollection<CentroCuenta>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<CentroCuenta>(page, rows);
        }

        public async Task<int> UpdateAsync(CentroCuenta CentroCuenta)
        {
            await _dbContext.UpdateAsync(CentroCuenta);
            return CentroCuenta.Id;
        }
    }
}
