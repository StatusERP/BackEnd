using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public class SeccionCuentaRepository : StatusERPContextBase<SeccionCuenta>, ISeccionCuentaRepository
    {

        public SeccionCuentaRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<SeccionCuenta?> BuscarCodSeccionCuentaAsync(string CodSeccionCuenta)
        {
            return await _dbContext.SeccionesCuentas
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodSeccionCuenta == CodSeccionCuenta);
        }

        public async Task<int> CreateAsync(SeccionCuenta SeccionCuenta)
        {
            return await _dbContext.InsertAsync(SeccionCuenta);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new SeccionCuenta
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<SeccionCuenta?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<SeccionCuenta>(id);
        }

        public async Task<ICollection<SeccionCuenta>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<SeccionCuenta>(page, rows);
        }

        public async Task<int> UpdateAsync(SeccionCuenta SeccionCuenta)
        {
            await _dbContext.UpdateAsync(SeccionCuenta,Mapper);
            return SeccionCuenta.Id;
        }
    }
}

