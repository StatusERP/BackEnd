using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS
{
    public class ImpuestoRepository : StatusERPContextBase<Impuesto>, IImpuestoRepository
    {

        public ImpuestoRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<Impuesto?> BuscarCodImpuestoAsync(string CodImpuesto)
        {
            return await _dbContext.Impuestos
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodImpuesto == CodImpuesto);
        }

        public async Task<int> CreateAsync(Impuesto Impuesto)
        {
            return await _dbContext.InsertAsync(Impuesto);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new Impuesto
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<Impuesto?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<Impuesto>(id);
        }

        public async Task<ICollection<Impuesto>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<Impuesto>(page, rows);
        }

        public async Task<int> UpdateAsync(Impuesto impuesto)
        {
            await _dbContext.UpdateAsync(impuesto,Mapper);
            return impuesto.Id;
        }
    }
}