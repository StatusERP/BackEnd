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

        public async Task<ICollection<Cobrador>> GetCollectionAsync()
        {
            return await _dbContext.Cobradores
                .Where(p => !p.IsDeleted)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<int> UpdateAsync(Cobrador cobrador)
        {

            try
            {
                var registro = await _dbContext.Set<Cobrador>()
               .AsNoTracking()
               .SingleOrDefaultAsync(x => x.Id == cobrador.Id && !x.IsDeleted);

                if (registro == null)
                {
                    return 0;
                }
                registro.Id = cobrador.Id;
                registro.CodCobrador = cobrador.CodCobrador;
                registro.Nombre = cobrador.Nombre;
                registro.Email = cobrador.Email;
                registro.Activo = cobrador.Activo;
                registro.IsDeleted = registro.IsDeleted;
                registro.Createdby = registro.Createdby;
                registro.CreateDate = registro.CreateDate;
                registro.Updatedby = cobrador.Updatedby;
                registro.UpdateDate = cobrador.UpdateDate;

                _dbContext.Set<Cobrador>().Attach(registro);
                _dbContext.Entry(registro).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }

            return cobrador.Id;
        }
    }
}
