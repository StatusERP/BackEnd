using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class TipoOperacionRepository : StatusERPContextBase<TipoOperacion>, ITipoOperacionRepository
    {

        public TipoOperacionRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<TipoOperacion?> BuscarCodTipoOperacionAsync(string CodTipoOperacion)
        {
            return await _dbContext.TiposOperacion
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodTipoOperacion == CodTipoOperacion);
        }

        public async Task<int> CreateAsync(TipoOperacion tipoOperacion)
        {
            return await _dbContext.InsertAsync(tipoOperacion);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new TipoOperacion
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<TipoOperacion?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<TipoOperacion>(id);
        }

        public async Task<ICollection<TipoOperacion>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<TipoOperacion>(page, rows);
        }

        public async Task<int> UpdateAsync(TipoOperacion tipoOperacion)
        {
            await _dbContext.UpdateAsync(tipoOperacion, Mapper);
            return tipoOperacion.Id;
        }
    }

}