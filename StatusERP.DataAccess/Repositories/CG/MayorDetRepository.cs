using AutoMapper;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public class MayorDetRepository : StatusERPContextBase<MayorDet>, IMayorDetRepository
    {

        public MayorDetRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<int> CreateAsync(MayorDet MayorDet)
        {
            return await _dbContext.InsertAsync(MayorDet);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new MayorDet
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<MayorDet?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<MayorDet>(id);
        }

        public async Task<ICollection<MayorDet>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<MayorDet>(page, rows);
        }

        public async Task<int> UpdateAsync(MayorDet MayorDet)
        {
            await _dbContext.UpdateAsync(MayorDet,Mapper);
            return MayorDet.Id;
        }
    }
}