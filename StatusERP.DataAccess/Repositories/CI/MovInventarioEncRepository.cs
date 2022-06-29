using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class MovInventarioEncRepository : StatusERPContextBase<MovInventarioEnc>, IMovInventarioEncRepository
    {

        public MovInventarioEncRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<MovInventarioEnc?> BuscarIdMovInventarioEncAsync(int IdMovInventarioEnc)
        {
            return await _dbContext.MovsInventarioEnc
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.Id == IdMovInventarioEnc);
        }

        public async Task<int> CreateAsync(MovInventarioEnc movInventarioEnc)
        {
            return await _dbContext.InsertAsync(movInventarioEnc);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new MovInventarioEnc
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<MovInventarioEnc?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<MovInventarioEnc>(id);
        }

        public async Task<ICollection<MovInventarioEnc>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<MovInventarioEnc>(page, rows);
        }

        public async Task<int> UpdateAsync(MovInventarioEnc movInventarioEnc)
        {
            //await _dbContext.UpdateAsync(movInventarioEnc,Mapper);
            //return movInventarioEnc.Id;

            try
            {
                var registro = await _dbContext.Set<MovInventarioEnc>()
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == movInventarioEnc.Id && !x.IsDeleted);

                if (registro == null)
                {
                    return 0;
                }

                registro.Id = movInventarioEnc.Id;
                registro.ConsecutivoId = movInventarioEnc.ConsecutivoId;
                registro.Usuario = movInventarioEnc.Usuario;
                registro.FechaHora  = movInventarioEnc.FechaHora;
                registro.ModuloOrigen = movInventarioEnc.ModuloOrigen;
                registro.Aplicacion  = movInventarioEnc.Aplicacion;
                registro.Referencia  = movInventarioEnc.Referencia;
                registro.Asiento  = movInventarioEnc.Asiento;
                registro.UsuarioAprob  = movInventarioEnc.UsuarioAprob;
                registro.FechaHoraAprob = movInventarioEnc.FechaHoraAprob;
                registro.PaqueteInventario = movInventarioEnc.PaqueteInventario;
                registro.IsDeleted = movInventarioEnc.IsDeleted;
                registro.Updatedby = movInventarioEnc.Updatedby;
                registro.UpdateDate = movInventarioEnc.UpdateDate;
                registro.Createdby = movInventarioEnc.Createdby;
                registro.CreateDate = movInventarioEnc.CreateDate;


                _dbContext.Set<MovInventarioEnc>().Attach(registro);
                _dbContext.Entry(registro).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();

            }

            catch (Exception ex)
            {
                Console.Write(ex);
            }

            return movInventarioEnc.Id;
        }
    }
}