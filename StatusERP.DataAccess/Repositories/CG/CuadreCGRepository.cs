using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public class CuadreCGRepository : StatusERPContextBase<CuadreCG>, ICuadreCGRepository
    {

        public CuadreCGRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<CuadreCG?> BuscarCodCuadreCGAsync(int CodCuadreCG)
        {
            return await _dbContext.CuadresCG
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodCuadreCG == CodCuadreCG);
        }

        public async Task<int> CreateAsync(CuadreCG CuadreCG)
        {
            return await _dbContext.InsertAsync(CuadreCG);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new CuadreCG
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<CuadreCG?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<CuadreCG>(id);
        }

        public async Task<ICollection<CuadreCG>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<CuadreCG>(page, rows);
        }

        public async Task<int> UpdateAsync(CuadreCG CuadreCG)
        {
            await _dbContext.UpdateAsync(CuadreCG,Mapper);
            return CuadreCG.Id;
        }
    }
}
