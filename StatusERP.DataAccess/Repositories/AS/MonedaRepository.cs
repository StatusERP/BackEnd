using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS
{
    public class MonedaRepository : StatusERPContextBase<Moneda>, IMonedaRepository
    {

        public MonedaRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<Moneda?> BuscarCodMonedaAsync(string CodMoneda)
        {
            return await _dbContext.Monedas
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodMoneda == CodMoneda);
        }

        public async Task<int> CreateAsync(Moneda Moneda)
        {
            return await _dbContext.InsertAsync(Moneda);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new Moneda
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<Moneda?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<Moneda>(id);
        }

        public async Task<ICollection<Moneda>> GetCollectionAsync()
        {

            return await _dbContext.Monedas
              .Where(p => !p.IsDeleted)
              .AsNoTracking()
              .ToListAsync();
        }

        public async Task<int> UpdateAsync(Moneda moneda)
        {

            try
            {
                var registro = await _dbContext.Set<Moneda>()
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == moneda.Id && !x.IsDeleted);

                if (registro == null)
                {
                    return 0;
                }

                registro.Id = moneda.Id;
                registro.CodMoneda = moneda.CodMoneda;
                registro.Nombre = moneda.Nombre;
                registro.CodigoISO = moneda.CodigoISO;
                registro.Activa = moneda.Activa;
                registro.IsDeleted = moneda.IsDeleted;
                registro.Updatedby = moneda.Updatedby;
                registro.UpdateDate = moneda.UpdateDate;
                registro.Createdby = registro.Createdby;
                registro.CreateDate = registro.CreateDate;

                _dbContext.Set<Moneda>().Attach(registro);
                _dbContext.Entry(registro).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();

            }

            catch (Exception ex)
            {
                Console.Write(ex);
            }

            return moneda.Id;

        }
    }
}
