using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public class MayorEncRepository : StatusERPContextBase<MayorEnc>, IMayorEncRepository
    {

        public MayorEncRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<MayorEnc?> BuscarCodMayorEncAsync(string Asiento)
        {
            return await _dbContext.MayorEnc
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.Asiento == Asiento);
        }

        public async Task<int> CreateAsync(MayorEnc MayorEnc)
        {
            return await _dbContext.InsertAsync(MayorEnc);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new MayorEnc
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<MayorEnc?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<MayorEnc>(id);
        }

        public async Task<ICollection<MayorEnc>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<MayorEnc>(page, rows);
        }

        public async Task<int> UpdateAsync(MayorEnc MayorEnc)
        {
            await _dbContext.UpdateAsync(MayorEnc,Mapper);
            return MayorEnc.Id;
        }
    }
}
