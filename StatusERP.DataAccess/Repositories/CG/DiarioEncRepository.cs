using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public class DiarioEncRepository : StatusERPContextBase<DiarioEnc>, IDiarioEncRepository
    {

        public DiarioEncRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<DiarioEnc?> BuscarCodDiarioEncAsync(string Asiento)
        {
            return await _dbContext.DiarioEnc
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.Asiento == Asiento);
        }

        public async Task<int> CreateAsync(DiarioEnc DiarioEnc)
        {
            return await _dbContext.InsertAsync(DiarioEnc);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new DiarioEnc
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<DiarioEnc?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<DiarioEnc>(id);
        }

        public async Task<ICollection<DiarioEnc>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<DiarioEnc>(page, rows);
        }

        public async Task<int> UpdateAsync(DiarioEnc DiarioEnc)
        {
            await _dbContext.UpdateAsync(DiarioEnc);
            return DiarioEnc.Id;
        }
    }
}