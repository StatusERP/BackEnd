using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class TipoPagoRepository : StatusERPContextBase<TipoPago>, ITipoPagoRepository
    {

        public TipoPagoRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<TipoPago?> BuscarCodTipoPagoAsync(string CodTipoPago)
        {
            return await _dbContext.TiposPago
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodTipoPago == CodTipoPago);
        }

        public async Task<int> CreateAsync(TipoPago tipoPago)
        {
            return await _dbContext.InsertAsync(tipoPago);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new TipoPago
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<TipoPago?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<TipoPago>(id);
        }

        public async Task<ICollection<TipoPago>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<TipoPago>(page, rows);
        }

        public async Task<int> UpdateAsync(TipoPago tipoPago)
        {
            await _dbContext.UpdateAsync(tipoPago);
            return tipoPago.Id;
        }
    }

}