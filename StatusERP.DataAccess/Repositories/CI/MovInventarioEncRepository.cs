using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class MovInventarioEncRepository : StatusERPContextBase<MovInventarioEnc>, IMovInventarioEncRepository
    {

        public MovInventarioEncRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<MovInventarioEnc?> BuscarIdMovInventarioEncAsync(int IdMovInventarioEnc)
        {
            return await _dbContext.MovsInventarioEnc
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.Id == IdMovInventarioEnc);
        }

        public async Task<int> CreateAsync(MovInventarioEnc movInventarioEnc)
        {
            return await _dbContext.InsertAsync(movInventarioEnc);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new MovInventarioEnc
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<MovInventarioEnc?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<MovInventarioEnc>(id);
        }

        public async Task<ICollection<MovInventarioEnc>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<MovInventarioEnc>(page, rows);
        }

        public async Task<int> UpdateAsync(MovInventarioEnc movInventarioEnc)
        {
            await _dbContext.UpdateAsync(movInventarioEnc, Mapper);
            return movInventarioEnc.Id;
        }
    }
}