using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class ExistenciaLoteRepository : StatusERPContextBase<ExistenciaLote>, IExistenciaLoteRepository
    {

        public ExistenciaLoteRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<ExistenciaLote?> BuscarExistenciaLoteAsync(int bodegaId, int articuloId, int localizacionId, int loteId)
        {
            return await _dbContext.ExistenciaLotes
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.BodegaId == bodegaId && t.ArticuloId == articuloId && t.LocalizacionId == localizacionId && t.LoteId == loteId);
        }

        public async Task<int> CreateAsync(ExistenciaLote existenciaLote)
        {
            return await _dbContext.InsertAsync(existenciaLote);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new ExistenciaLote
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<ExistenciaLote?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<ExistenciaLote>(id);
        }

        public async Task<ICollection<ExistenciaLote>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<ExistenciaLote>(page, rows);
        }

        public async Task<int> UpdateAsync(ExistenciaLote existenciaLote)
        {
            await _dbContext.UpdateAsync(existenciaLote,Mapper);
            return existenciaLote.Id;
        }
    }
}
