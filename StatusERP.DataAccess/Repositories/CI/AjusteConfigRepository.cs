using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class AjusteConfigRepository : StatusERPContextBase<AjusteConfig>, IAjusteConfigRepository
    {

        public AjusteConfigRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<AjusteConfig?> BuscarCodAjusteConfigAsync(string CodAjusteConfig)
        {
            return await _dbContext.AjustesConfig
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodAjusteConfig == CodAjusteConfig);
        }

        public async Task<int> CreateAsync(AjusteConfig ajusteConfig)
        {
            return await _dbContext.InsertAsync(ajusteConfig);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new AjusteConfig
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<AjusteConfig?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<AjusteConfig>(id);
        }

        public async Task<ICollection<AjusteConfig>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<AjusteConfig>(page, rows);
        }

        public async Task<int> UpdateAsync(AjusteConfig ajusteConfig)
        {
            await _dbContext.UpdateAsync(ajusteConfig);
            return ajusteConfig.Id;
        }
    }
}
