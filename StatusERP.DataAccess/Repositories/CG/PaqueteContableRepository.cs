using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public class PaqueteContableRepository : StatusERPContextBase<PaqueteContable>, IPaqueteContableRepository
    {

        public PaqueteContableRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<PaqueteContable?> BuscarCodPaqueteContableAsync(string codPaquete)
        {
            return await _dbContext.PaquetesContables
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodPaquete == codPaquete);
        }

        public async Task<int> CreateAsync(PaqueteContable paqueteContable)
        {
            return await _dbContext.InsertAsync(paqueteContable);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new PaqueteContable
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<PaqueteContable?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<PaqueteContable>(id);
        }

        public async Task<ICollection<PaqueteContable>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<PaqueteContable>(page, rows);
        }

        public async Task<int> UpdateAsync(PaqueteContable paqueteContable)
        {
            //await _dbContext.UpdateAsync(paqueteContable, Mapper);
            //return paqueteContable.Id;

            try
            {
                var registro = await _dbContext.Set<PaqueteContable>()
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == paqueteContable.Id && !x.IsDeleted);

                if (registro == null)
                {
                    return 0;
                }

                registro.Id = paqueteContable.Id;
                registro.CodPaquete = paqueteContable.CodPaquete;
                registro.Descripcion = paqueteContable.Descripcion;
                registro.UsuarioCreador = paqueteContable.UsuarioCreador;
                registro.UltimoUsuario = paqueteContable.UltimoUsuario;
                registro.FechaUltAcceso = paqueteContable.FechaUltAcceso;
                registro.UltimoAsiento = paqueteContable.UltimoAsiento;
                registro.Marcado = paqueteContable.Marcado;
                registro.IsDeleted = paqueteContable.IsDeleted;
                registro.Updatedby = paqueteContable.Updatedby;
                registro.UpdateDate = paqueteContable.UpdateDate;
                registro.Createdby = registro.Createdby;
                registro.CreateDate = registro.CreateDate;

                _dbContext.Set<PaqueteContable>().Attach(registro);
                _dbContext.Entry(registro).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();

            }

            catch (Exception ex)
            {
                Console.Write(ex);
            }

            return paqueteContable.Id;
        }
    }
}
