using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class IngresoLoteRepository : StatusERPContextBase<Lote>, IIngresoLoteRepository
    {

        public IngresoLoteRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<IngresoLote?> BuscarIngresoLoteAsync(int articulo, int lote, int secuenciaLote)
        {
            return await _dbContext.IngresosLotes
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.Articulo == articulo && t.Lote == lote && t.SecuenciaLote == secuenciaLote);
        }

        public async Task<int> CreateAsync(IngresoLote ingresoLote)
        {
            return await _dbContext.InsertAsync(ingresoLote);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new IngresoLote
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<IngresoLote?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<IngresoLote>(id);
        }

        public async Task<ICollection<IngresoLote>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<IngresoLote>(page, rows);
        }

        public async Task<int> UpdateAsync(IngresoLote ingresoLote)
        {
            await _dbContext.UpdateAsync(ingresoLote,Mapper);
            return ingresoLote.Id;
        }
    }
}