using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS
{
    public class CobradorRepository : StatusERPContextBase<Cobrador>, ICobradorRepository
    {
        public CobradorRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<int> CreateAsync(Cobrador cobrador)
        {
            return await _dbContext.InsertAsync(cobrador);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new Cobrador
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public  async Task<Cobrador?> BuscarCodCobradorAsync(string codCobrador)
        {
       
            return await _dbContext.Cobradores
                .AsNoTracking()
                .FirstOrDefaultAsync(t => t.CodCobrador == codCobrador );
        }
        public async Task<Cobrador?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<Cobrador>(id);
        }

        public async Task<ICollection<Cobrador>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<Cobrador>(page, rows);
        }

        public async Task<int> UpdateAsync(Cobrador cobrador)
        {
            await _dbContext.UpdateAsync(cobrador,Mapper);
            return cobrador.Id;
        }
    }
}
