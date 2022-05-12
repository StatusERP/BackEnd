using AutoMapper;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public class DiarioDetRepository : StatusERPContextBase<DiarioDet>, IDiarioDetRepository
    {

        public DiarioDetRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<int> CreateAsync(DiarioDet DiarioDet)
        {
            return await _dbContext.InsertAsync(DiarioDet);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new DiarioDet
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<DiarioDet?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<DiarioDet>(id);
        }

        public async Task<ICollection<DiarioDet>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<DiarioDet>(page, rows);
        }

        public async Task<int> UpdateAsync(DiarioDet DiarioDet)
        {
            await _dbContext.UpdateAsync(DiarioDet);
            return DiarioDet.Id;
        }
    }
}