using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS
{
    public class RutaRepository : StatusERPContextBase<Ruta>, IRutaRepository
    {

        public RutaRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<Ruta?> BuscarCodRutaAsync(string codRuta)
        {
            return await _dbContext.Rutas
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodRuta == codRuta);
        }

        public async Task<int> CreateAsync(Ruta ruta)
        {
            return await _dbContext.InsertAsync(ruta);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new Ruta
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<Ruta?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<Ruta>(id);
        }

        public async Task<ICollection<Ruta>> GetCollectionAsync()
        {

            return await _dbContext.Rutas
              .Where(p => !p.IsDeleted)
              .AsNoTracking()
              .ToListAsync();
        }

        public async Task<int> UpdateAsync(Ruta ruta)
        {

            try
            {
                var registro = await _dbContext.Set<Ruta>()
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == ruta.Id && !x.IsDeleted);

                if (registro == null)
                {
                    return 0;
                }

                registro.Id = ruta.Id;
                registro.CodRuta = ruta.CodRuta;
                registro.Descripcion = ruta.Descripcion;
                registro.Activa = ruta.Activa;
                registro.IsDeleted = registro.IsDeleted;
                registro.Updatedby = ruta.Updatedby;
                registro.UpdateDate = ruta.UpdateDate;
                registro.Createdby = registro.Createdby;
                registro.CreateDate = registro.CreateDate;


                _dbContext.Set<Ruta>().Attach(registro);
                _dbContext.Entry(registro).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();

            }

            catch (Exception ex)
            {
                Console.Write(ex);
            }

            return ruta.Id;

        }
    }
}