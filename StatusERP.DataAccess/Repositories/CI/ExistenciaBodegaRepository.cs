using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class ExistenciaBodegaRepository : StatusERPContextBase<ExistenciaBodega>, IExistenciaBodegaRepository
    {

        public ExistenciaBodegaRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<ICollection<ExistenciaBodega>> BuscarExistenciaXArticulo(int articuloId)
        {
            return await _dbContext.ExistenciaBodega
                .AsNoTracking()
                .Where(x => x.ArticuloId == articuloId)
                .ToListAsync();
               

        }

        public async Task<ExistenciaBodega?> BuscarIdExistenciaBodegaAsync(int articuloId, int bodegaId)
        {
            return await _dbContext.ExistenciaBodega
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.ArticuloId  == articuloId && t.BodegaId == bodegaId);
        }

        public async Task<int> CreateAsync(ExistenciaBodega existenciaBodega)
        {
            return await _dbContext.InsertAsync(existenciaBodega);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new ExistenciaBodega
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<ExistenciaBodega?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<ExistenciaBodega>(id);
        }

        public async Task<ICollection<ExistenciaBodega>> GetCollectionAsync(int page, int rows)
        {
            //return await _dbContext.SelectAsync<ExistenciaBodega>(page, rows);

            return await _dbContext.ExistenciaBodega
             .Include(p=>p.bodega)
             .Where(p => !p.IsDeleted)
             .AsNoTracking()
              .Skip((page - 1) * rows)
             .Take(rows)
             .ToListAsync();
        }



    

        public async Task<int> UpdateAsync(ExistenciaBodega existenciaBodega)
        {
            try
            {
                var registro = await _dbContext.Set<ExistenciaBodega>()
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == existenciaBodega.Id && !x.IsDeleted);

                if (registro == null)
                {
                    return 0;
                }

                registro.ExistenciaMinima = existenciaBodega.ExistenciaMinima;
                registro.ExistenciaMaxima = existenciaBodega.ExistenciaMaxima;
                registro.PuntoDeOrden = existenciaBodega.PuntoDeOrden;
                registro.CantDisponible = existenciaBodega.CantDisponible;
                registro.CantReservada = existenciaBodega.CantReservada;
                registro.CantNoAprobada = existenciaBodega.CantNoAprobada;
                registro.CantVencida = existenciaBodega.CantVencida;
                registro.CantTransito = existenciaBodega.CantTransito;
                registro.CantProduccion = existenciaBodega.CantProduccion;
                registro.CantPedida = existenciaBodega.CantPedida;
                registro.CantRemitida = existenciaBodega.CantRemitida;
                registro.Congelado = existenciaBodega.Congelado;
                registro.FechaCong = existenciaBodega.FechaCong;
                registro.BloqueaTrans = existenciaBodega.BloqueaTrans;
                registro.FechaDescong = existenciaBodega.FechaDescong;
                registro.CostoUntPromedioDol = existenciaBodega.CostoUntPromedioDol;
                registro.CostoUntPromedioLoc = existenciaBodega.CostoUntPromedioLoc;
                registro.IsDeleted = existenciaBodega.IsDeleted;
                registro.Updatedby = existenciaBodega.Updatedby;
                registro.UpdateDate =existenciaBodega.UpdateDate;
                registro.Createdby = existenciaBodega.Createdby;
                registro.CreateDate = existenciaBodega.CreateDate;





                _dbContext.Set<ExistenciaBodega>().Attach(registro);
                _dbContext.Entry(registro).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }

            return existenciaBodega.Id;





            
        }
    }
}
