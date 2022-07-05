using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class ConsecutivoInvRepository : StatusERPContextBase<ConsecutivoInv>, IConsecutivoInvRepository
    {

        public ConsecutivoInvRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<ConsecutivoInv?> BuscarCodConsecutivoInvAsync(string CodConsecutivo)
        {
            return await _dbContext.ConsecutivosInv
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodConsecutivo == CodConsecutivo);
        }

        public async Task<int> CreateAsync(ConsecutivoInv consecutivoInv)
        {
            return await _dbContext.InsertAsync(consecutivoInv);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new ConsecutivoInv
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<ConsecutivoInv?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<ConsecutivoInv>(id);
        }

        public async Task<ICollection<ConsecutivoInv>> GetCollectionAsync(int page, int rows)
        {


            return await _dbContext.SelectAsync<ConsecutivoInv>(page, rows);
        }

        public async Task<int> UpdateAsync(ConsecutivoInv consecutivoInv)
        {
            await _dbContext.UpdateAsync(consecutivoInv,Mapper);
            return consecutivoInv.Id;
        }
    }

}
