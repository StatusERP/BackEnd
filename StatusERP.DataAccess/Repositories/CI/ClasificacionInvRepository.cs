using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class ClasificacionInvRepository : StatusERPContextBase<ClasificacionInv>, IClasificacionInvRepository
    {

        public ClasificacionInvRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<ClasificacionInv?> BuscarCodClasificacionInvAsync(string CodClasificacion)
        {
            return await _dbContext.ClasificacionesInv
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodClasificacion == CodClasificacion);
        }

        public async Task<int> CreateAsync(ClasificacionInv ClasificacionInv)
        {
            return await _dbContext.InsertAsync(ClasificacionInv);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new ClasificacionInv
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<ClasificacionInv?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<ClasificacionInv>(id);
        }

        public async Task<ICollection<ClasificacionInv>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<ClasificacionInv>(page, rows);
        }

        public async Task<int> UpdateAsync(ClasificacionInv ClasificacionInv)
        {
            await _dbContext.UpdateAsync(ClasificacionInv, Mapper);
            return ClasificacionInv.Id;
        }
    }
}
