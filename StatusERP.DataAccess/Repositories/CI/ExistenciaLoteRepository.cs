using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class ExistenciaLoteRepository : StatusERPContextBase<ExistenciaLote>, IExistenciaLoteRepository
    {

        public ExistenciaLoteRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<ExistenciaLote?> BuscarExistenciaLoteAsync(int bodegaId, int articuloId, int localizacionId, int loteId)
        {
            return await _dbContext.ExistenciaLotes
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.BodegaId == bodegaId && t.ArticuloId == articuloId && t.LocalizacionId == localizacionId && t.LoteId == loteId);
        }

        public async Task<int> CreateAsync(ExistenciaLote existenciaLote)
        {
            return await _dbContext.InsertAsync(existenciaLote);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new ExistenciaLote
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<ExistenciaLote?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<ExistenciaLote>(id);
        }

        public async Task<ICollection<ExistenciaLote>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<ExistenciaLote>(page, rows);
        }

        public async Task<int> UpdateAsync(ExistenciaLote existenciaLote)
        {
            //await _dbContext.UpdateAsync(existenciaLote,Mapper);
            //return existenciaLote.Id;

            try
            {
                var registro = await _dbContext.Set<ExistenciaLote>()
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == existenciaLote.Id && !x.IsDeleted);

                if (registro == null)
                {
                    return 0;
                }

                registro.BodegaId = existenciaLote.BodegaId;
                registro.ArticuloId = existenciaLote.ArticuloId;
                registro.LocalizacionId = existenciaLote.LocalizacionId;
                registro.LoteId = existenciaLote.LoteId;
                registro.CantDisponible = existenciaLote.CantDisponible;
                registro.CantReservada = existenciaLote.CantReservada;
                registro.CantNoAprobada = existenciaLote.CantNoAprobada;
                registro.CantVencida = existenciaLote.CantVencida;
                registro.CantRemitida = existenciaLote.CantRemitida;
                registro.CostoUntLoc = existenciaLote.CostoUntLoc;
                registro.CostoUntDol = existenciaLote.CostoUntDol;
                registro.IsDeleted = existenciaLote.IsDeleted;
                registro.Updatedby = existenciaLote.Updatedby;
                registro.UpdateDate = DateTime.Now;
                registro.Createdby = existenciaLote.Createdby;
                registro.CreateDate = existenciaLote.CreateDate;
                


                _dbContext.Set<ExistenciaLote>().Attach(registro);
                _dbContext.Entry(registro).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();

            }

            catch (Exception ex)
            {
                Console.Write(ex);
            }

            return existenciaLote.Id;


        }
    }
}
