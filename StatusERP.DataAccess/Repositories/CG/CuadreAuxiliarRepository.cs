using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public class CuadreAuxiliarRepository : StatusERPContextBase<CuadreAuxiliar>, ICuadreAuxiliarRepository
    {

        public CuadreAuxiliarRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<int> CreateAsync(CuadreAuxiliar CuadreAuxiliar)
        {
            return await _dbContext.InsertAsync(CuadreAuxiliar);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new CuadreAuxiliar
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<CuadreAuxiliar?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<CuadreAuxiliar>(id);
        }

        public async Task<ICollection<CuadreAuxiliar>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<CuadreAuxiliar>(page, rows);
        }

        public async Task<int> UpdateAsync(CuadreAuxiliar CuadreAuxiliar)
        {
            await _dbContext.UpdateAsync(CuadreAuxiliar);
            return CuadreAuxiliar.Id;
        }
    }
}
