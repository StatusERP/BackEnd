using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class LoteRepository : StatusERPContextBase<Lote>, ILoteRepository
    {

        public LoteRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<Lote?> BuscarLoteArticuloAsync(string CodLote, int ArticuloId)
        {
            return await _dbContext.Lotes
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodLote == CodLote && t.ArticuloId == ArticuloId);
        }

        public async Task<int> CreateAsync(Lote Lote)
        {
            return await _dbContext.InsertAsync(Lote);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new Lote
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<Lote?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<Lote>(id);
        }

        public async Task<ICollection<Lote>> GetCollectionAsync(int page, int rows)
        {

            return await _dbContext.Lotes
              .Where(p => !p.IsDeleted)
              .AsNoTracking()
               .Skip((page - 1) * rows)
              .Take(rows)
              .ToListAsync();

            
        }

        public async Task<int> UpdateAsync(Lote Lote)
        {
            await _dbContext.UpdateAsync(Lote,Mapper);
            return Lote.Id;
        }
    }
}