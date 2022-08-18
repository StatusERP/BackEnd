using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS
{
    public class DireccionRepository : StatusERPContextBase<Direccion>, IDireccionRepository
    {

        public DireccionRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<Direccion?> BuscarDireccionAsync(string CodDireccion)
        {
            return await _dbContext.Direcciones
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodDireccion == CodDireccion);
        }

        public async Task<int> CreateAsync(Direccion direccion)
        {
            return await _dbContext.InsertAsync(direccion);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new Direccion
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<Direccion?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<Direccion>(id);
        }

        public async Task<ICollection<Direccion>> GetCollectionAsync(int page, int rows)
        {

            return await _dbContext.Direcciones
              .Where(p => !p.IsDeleted)
              .AsNoTracking()
              .ToListAsync();
        }

        public async Task<int> UpdateAsync(Direccion direccion)
        {
            //await _dbContext.UpdateAsync(direccion, Mapper);
            //return direccion.Id;

            try
            {
                var registro = await _dbContext.Set<Direccion>()
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == direccion.Id && !x.IsDeleted);

                if (registro == null)
                {
                    return 0;
                }

                registro.Id = direccion.Id;
                registro.CodDireccion = direccion.CodDireccion;
                registro.Descripcion = direccion.Descripcion;
                registro.NombreCampo01 = direccion.NombreCampo01;
                registro.NombreCampo02 = direccion.NombreCampo02;
                registro.NombreCampo03 = direccion.NombreCampo03;
                registro.NombreCampo04 = direccion.NombreCampo04;
                registro.NombreCampo05 = direccion.NombreCampo05;
                registro.NombreCampo06 = direccion.NombreCampo06;
                registro.NombreCampo07 = direccion.NombreCampo07;
                registro.NombreCampo08 = direccion.NombreCampo08;
                registro.NombreCampo09 = direccion.NombreCampo09;
                registro.NombreCampo10 = direccion.NombreCampo10;


                _dbContext.Set<Direccion>().Attach(registro);
                _dbContext.Entry(registro).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();

            }

            catch (Exception ex)
            {
                Console.Write(ex);
            }

            return direccion.Id;

        }
    }
}
