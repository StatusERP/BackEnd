using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public class GlobalesCGRepository : StatusERPContextBase<GlobalesCG>, IGlobalesCGRepository
    {

        public GlobalesCGRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<int> CreateAsync(GlobalesCG GlobalesCG)
        {
            return await _dbContext.InsertAsync(GlobalesCG);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new GlobalesCG
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<GlobalesCG?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<GlobalesCG>(id);
        }

        public async Task<ICollection<GlobalesCG>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<GlobalesCG>(page, rows);
        }

        public async Task<int> UpdateAsync(GlobalesCG GlobalesCG)
        {
            await _dbContext.UpdateAsync(GlobalesCG,Mapper);
            return GlobalesCG.Id;
        }
    }
}