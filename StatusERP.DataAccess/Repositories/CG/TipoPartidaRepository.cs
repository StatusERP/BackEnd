using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public class TipoPartidaRepository : StatusERPContextBase<TipoPartida>, ITipoPartidaRepository
    {

        public TipoPartidaRepository(StatusERPDBContext context ,IMapper mapper):base(context,mapper)
        {

        }

        public async Task<TipoPartida?> BuscarCodTipoPartidaAsync(string codTipoPartida)
        {
            return await _dbContext.TiposPartidas
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodTipoPartida == codTipoPartida);
        }

        public async Task<int> CreateAsync(TipoPartida tipoPartida)
        {
            return await _dbContext.InsertAsync(tipoPartida);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new TipoPartida
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<TipoPartida?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<TipoPartida>(id);
        }

        public async Task<ICollection<TipoPartida>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<TipoPartida>(page, rows);
        }

        public async Task<int> UpdateAsync(TipoPartida tipoPartida)
        {
            await _dbContext.UpdateAsync(tipoPartida);
            return tipoPartida.Id;
        }
    }
}
