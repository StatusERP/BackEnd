using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class ExistenciaBodegaRepository : StatusERPContextBase<ExistenciaBodega>, IExistenciaBodegaRepository
    {

        public ExistenciaBodegaRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<ExistenciaBodega?> BuscarIdExistenciaBodegaAsync(int articuloId, int bodegaId)
        {
            return await _dbContext.ExistenciaBodega
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.ArticuloId  == articuloId && t.BodegaId == bodegaId);
        }

        public async Task<int> CreateAsync(ExistenciaBodega existenciaBodega)
        {
            return await _dbContext.InsertAsync(existenciaBodega);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new ExistenciaBodega
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<ExistenciaBodega?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<ExistenciaBodega>(id);
        }

        public async Task<ICollection<ExistenciaBodega>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<ExistenciaBodega>(page, rows);
        }

        public async Task<int> UpdateAsync(ExistenciaBodega ExistenciaBodega)
        {
            await _dbContext.UpdateAsync(ExistenciaBodega);
            return ExistenciaBodega.Id;
        }
    }
}
