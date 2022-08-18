using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS
{
    public class DetalleDireccionRepository : StatusERPContextBase<DetalleDireccion>, IDetalleDireccionRepository
    {

        public DetalleDireccionRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<DetalleDireccion?> BuscarCodDetalleDireccionAsync(int CodDetalleDireccion)
        {
            return await _dbContext.DetalleDirecciones
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodDetalleDireccion == CodDetalleDireccion);
        }

        public async Task<int> CreateAsync(DetalleDireccion detalleDireccion)
        {
            return await _dbContext.InsertAsync(detalleDireccion);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new DetalleDireccion
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<DetalleDireccion?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<DetalleDireccion>(id);
        }

        public async Task<ICollection<DetalleDireccion>> GetCollectionAsync()

        {


            return await _dbContext.DetalleDirecciones
              .Include(p => p.Direccion)
              .Where(p => !p.IsDeleted)
              .AsNoTracking()
              .ToListAsync();
        }

        public async Task<int> UpdateAsync(DetalleDireccion detalleDireccion)
        {

            try
            {
                var registro = await _dbContext.Set<DetalleDireccion>()
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == detalleDireccion.Id && !x.IsDeleted);

                if (registro == null)
                {
                    return 0;
                }

                registro.Id = detalleDireccion.Id;
                registro.CodDetalleDireccion = detalleDireccion.CodDetalleDireccion;
                registro.DireccionId = detalleDireccion.DireccionId;
                registro.Campo01 = detalleDireccion.Campo01;
                registro.Campo02 = detalleDireccion.Campo02;
                registro.Campo03 = detalleDireccion.Campo03;
                registro.Campo04 = detalleDireccion.Campo04;
                registro.Campo05 = detalleDireccion.Campo05;
                registro.Campo06 = detalleDireccion.Campo06;
                registro.Campo07 = detalleDireccion.Campo07;
                registro.Campo08 = detalleDireccion.Campo08;
                registro.Campo09 = detalleDireccion.Campo09;
                registro.Campo10 = detalleDireccion.Campo10;
                registro.IsDeleted = registro.IsDeleted;
                registro.Createdby = registro.Createdby;
                registro.CreateDate = registro.CreateDate;
                registro.Updatedby = detalleDireccion.Updatedby;
                registro.UpdateDate = detalleDireccion.UpdateDate;

                _dbContext.Set<DetalleDireccion>().Attach(registro);
                _dbContext.Entry(registro).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
            }

            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return detalleDireccion.Id;
        }
    }
}