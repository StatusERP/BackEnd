using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public class CuadreContaRepository : StatusERPContextBase<CuadreConta>, ICuadreContaRepository
    {

        public CuadreContaRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<int> CreateAsync(CuadreConta CuadreConta)
        {
            return await _dbContext.InsertAsync(CuadreConta);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new CuadreConta
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<CuadreConta?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<CuadreConta>(id);
        }

        public async Task<ICollection<CuadreConta>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<CuadreConta>(page, rows);
        }

        public async Task<int> UpdateAsync(CuadreConta CuadreConta)
        {
            await _dbContext.UpdateAsync(CuadreConta,Mapper);
            return CuadreConta.Id;
        }
    }
}