using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Entities.AS.Tablas;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace StatusERP.DataAccess.Repositories.AS
{
    public class LocalizacionesRepository : StatusERPContextBase<Localizacion>, ILocalizacionesRepository
    {
        public LocalizacionesRepository(StatusERPDBContext context,IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<int> CreateAsync(Localizacion localizacion)
        {
            return await _dbContext.InsertAsync(localizacion);   
        }

        public  async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new Localizacion
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<Localizacion?> BuscarCodLocalizacionAsync(string codLocalizacion)
        {
            return await _dbContext.Localizaciones
                .AsNoTracking()
                .FirstOrDefaultAsync(t => t.CodLocalizacion == codLocalizacion );
        }

        public async Task<Localizacion?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<Localizacion>(id);
        }

        public async Task<ICollection<Localizacion>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<Localizacion>(page, rows);
        }

        public async Task<int> UpdateAsync(Localizacion localizacion)
        {
            await _dbContext.UpdateAsync(localizacion);
            return localizacion.Id;
        }

        public async Task<ICollection<Localizacion>> GetByIdBodegaAsync(int id)
        {
            return await _dbContext.Localizaciones.Where(p => p.BodegaId == id).ToListAsync();

            
        }
    }
}
