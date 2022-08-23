using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.AS.Tablas;
using StatusERP.DataAccess.Repositories.AS.Interfaces;

namespace StatusERP.DataAccess.Repositories.AS
{
    public class DocTributarioRepository : StatusERPContextBase<DocTributario>, IDocTributarioRepository
    {

        public DocTributarioRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<DocTributario?> BuscarNumDocTributarioAsync(string numDocTributario)
        {
            return await _dbContext.DocTributarios
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.NumDocTributario == numDocTributario);
        }

        public async Task<int> CreateAsync(DocTributario docTributario)
        {
            return await _dbContext.InsertAsync(docTributario);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new DocTributario
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<DocTributario?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<DocTributario>(id);
        }

        public async Task<ICollection<DocTributario>> GetCollectionAsync()
        {

            return await _dbContext.DocTributarios
            .Include(p => p.TipoDocTributario)
            .Where(p => !p.IsDeleted)
            .AsNoTracking()
            .ToListAsync();
        }

        public async Task<int> UpdateAsync(DocTributario docTributario)
        {

            try
            {
                var registro = await _dbContext.Set<DocTributario>()
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == docTributario.Id && !x.IsDeleted);

                if (registro == null)
                {
                    return 0;
                }

                registro.Id = docTributario.Id;
                registro.NumDocTributario = docTributario.NumDocTributario;
                registro.RazonSocial = docTributario.RazonSocial;
                registro.Alias = docTributario.Alias;
                registro.Notas = docTributario.Notas;
                registro.TipoDocTributarioId = docTributario.TipoDocTributarioId;
                registro.DigitoVerificador = docTributario.DigitoVerificador;
                registro.Activo = docTributario.Activo;
                registro.TipoContribuyente = docTributario.TipoContribuyente;
                registro.NRC = docTributario.NRC;
                registro.Giro = docTributario.Giro;
                registro.Categoria = docTributario.Categoria;
                registro.DUI = docTributario.DUI;
                registro.Pasaporte = docTributario.Pasaporte;
                registro.Carnet = docTributario.Carnet;
                registro.Otro = docTributario.Otro;
                registro.InfoLegal = docTributario.InfoLegal;
                registro.Updatedby = docTributario.Updatedby;
                registro.UpdateDate = docTributario.UpdateDate;
                registro.Createdby = registro.Createdby;
                registro.CreateDate = registro.CreateDate;


                _dbContext.Set<DocTributario>().Attach(registro);
                _dbContext.Entry(registro).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();

            }

            catch (Exception ex)
            {
                Console.Write(ex);
            }

            return docTributario.Id;

        }
    }
}