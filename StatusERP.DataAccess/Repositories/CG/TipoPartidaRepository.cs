using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public class TipoPartidaRepository : StatusERPContextBase<TipoPartida>, ITipoPartidaRepository
    {

        public TipoPartidaRepository(StatusERPDBContext context ,IMapper mapper):base(context,mapper)
        {

        }

        public async Task<TipoPartida?> BuscarCodTipoPartidaAsync(string codTipoPartida)
        {
            return await _dbContext.TiposPartidas
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodTipoPartida == codTipoPartida);
        }

        public async Task<int> CreateAsync(TipoPartida tipoPartida)
        {
            return await _dbContext.InsertAsync(tipoPartida);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new TipoPartida
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<TipoPartida?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<TipoPartida>(id);
        }

        public async Task<ICollection<TipoPartida>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<TipoPartida>(page, rows);
        }

        public async Task<int> UpdateAsync(TipoPartida tipoPartida)
        {
            try
            {
                var registro = await _dbContext.Set<TipoPartida>()
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == tipoPartida.Id && !x.IsDeleted);

                if (registro == null)
                {
                    return 0;
                }

                registro.Id = tipoPartida.Id;
                registro.CodTipoPartida = tipoPartida.CodTipoPartida;
                registro.Descripcion = tipoPartida.Descripcion;
                registro.IsDeleted = registro.IsDeleted;
                registro.Updatedby = tipoPartida.Updatedby;
                registro.UpdateDate = tipoPartida.UpdateDate;
                registro.Createdby = registro.Createdby;
                registro.CreateDate = registro.CreateDate;

                _dbContext.Set<TipoPartida>().Attach(registro);
                _dbContext.Entry(registro).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();

            }

            catch (Exception ex)
            {
                Console.Write(ex);
            }

            return tipoPartida.Id;
        }
    }
}
