using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public class PaqueteContableRepository : StatusERPContextBase<PaqueteContable>, IPaqueteContableRepository
    {

        public PaqueteContableRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<PaqueteContable?> BuscarCodPaqueteContableAsync(string CodPaquete)
        {
            return await _dbContext.PaquetesContables
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodPaquete == CodPaquete);
        }

        public async Task<int> CreateAsync(PaqueteContable PaqueteContable)
        {
            return await _dbContext.InsertAsync(PaqueteContable);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new PaqueteContable
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<PaqueteContable?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<PaqueteContable>(id);
        }

        public async Task<ICollection<PaqueteContable>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<PaqueteContable>(page, rows);
        }

        public async Task<int> UpdateAsync(PaqueteContable PaqueteContable)
        {
            await _dbContext.UpdateAsync(PaqueteContable);
            return PaqueteContable.Id;
        }
    }
}
