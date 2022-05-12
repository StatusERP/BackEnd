using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class PaqueteInvRepository : StatusERPContextBase<PaqueteInv>, IPaqueteInvRepository
    {

        public PaqueteInvRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<PaqueteInv?> BuscarCodPaqueteInvAsync(string CodPaqueteInv)
        {
            return await _dbContext.PaquetesInv 
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodPaqueteInv == CodPaqueteInv);
        }

        public async Task<int> CreateAsync(PaqueteInv paqueteInv)
        {
            return await _dbContext.InsertAsync(paqueteInv);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new PaqueteInv
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<PaqueteInv?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<PaqueteInv>(id);
        }

        public async Task<ICollection<PaqueteInv>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<PaqueteInv>(page, rows);
        }

        public async Task<int> UpdateAsync(PaqueteInv paqueteInv)
        {
            await _dbContext.UpdateAsync(paqueteInv);
            return paqueteInv.Id;
        }
    }
}
