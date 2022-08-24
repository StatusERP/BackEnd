using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS
{
    public class TipoDocTributarioRepository : StatusERPContextBase<TipoDocTributario>, ITipoDocTributarioRepository
    {

        public TipoDocTributarioRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<TipoDocTributario?> BuscarTipoDocTributarioAsync(string codTipoDT)
        {
            return await _dbContext.TiposDocTributarios
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodTipoDT == codTipoDT);
        }

        public async Task<int> CreateAsync(TipoDocTributario tipoDocTributario)
        {
            return await _dbContext.InsertAsync(tipoDocTributario);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new TipoDocTributario
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<TipoDocTributario?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<TipoDocTributario>(id);
        }

        public async Task<ICollection<TipoDocTributario>> GetCollectionAsync()
        {

            return await _dbContext.TiposDocTributarios
              .Where(p => !p.IsDeleted)
              .AsNoTracking()
              .ToListAsync();
        }

        public async Task<int> UpdateAsync(TipoDocTributario tipoDocTributario)
        {

            try
            {
                var registro = await _dbContext.Set<TipoDocTributario>()
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == tipoDocTributario.Id && !x.IsDeleted);

                if (registro == null)
                {
                    return 0;
                }

                registro.Id = tipoDocTributario.Id;
                registro.CodTipoDT = tipoDocTributario.CodTipoDT;
                registro.Descripcion = tipoDocTributario.Descripcion;
                registro.Mascara = tipoDocTributario.Mascara;
                registro.IsDeleted = registro.IsDeleted;
                registro.Updatedby = tipoDocTributario.Updatedby;
                registro.UpdateDate = tipoDocTributario.UpdateDate;
                registro.Createdby = registro.Createdby;
                registro.CreateDate = registro.CreateDate;


                _dbContext.Set<TipoDocTributario>().Attach(registro);
                _dbContext.Entry(registro).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();

            }

            catch (Exception ex)
            {
                Console.Write(ex);
            }

            return tipoDocTributario.Id;

        }
    }
}
