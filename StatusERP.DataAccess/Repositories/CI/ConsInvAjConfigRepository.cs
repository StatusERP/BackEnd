using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class ConsInvAjConfigRepository : StatusERPContextBase<ConsInvAjConfig>, IConsInvAjConfigRepository
    {

        public ConsInvAjConfigRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<ConsInvAjConfig?> BuscarConsecAjusteAsync(int ConsecutivoId, int AjusteId)
        {
            return await _dbContext.ConsInvAjConfig 
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.ConsecutivoInvId == ConsecutivoId && t.AjusteConfigId == AjusteId);
        }

        public async Task<int> CreateAsync(ConsInvAjConfig consInvAjConfig)
        {
            return await _dbContext.InsertAsync(consInvAjConfig);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new ConsInvAjConfig
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<ConsInvAjConfig?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<ConsInvAjConfig>(id);
        }

        public async Task<ICollection<ConsInvAjConfig>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<ConsInvAjConfig>(page, rows);
        }

        public async Task<int> UpdateAsync(ConsInvAjConfig consInvAjConfig)
        {
            await _dbContext.UpdateAsync(consInvAjConfig,Mapper);
            return consInvAjConfig.Id;
        }
    }
}
