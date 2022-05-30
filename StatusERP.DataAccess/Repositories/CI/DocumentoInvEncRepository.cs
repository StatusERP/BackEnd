using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class DocumentoInvEncRepository : StatusERPContextBase<DocumentoInvEnc>, IDocumentoInvEncRepository
    {

        public DocumentoInvEncRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<DocumentoInvEnc?> BuscarDocumentoInvEncAsync(string paquete, string documento)
        {
            return await _dbContext.DocumentosInvEnc
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.PaqueteInventario == paquete && t.DocumentoInv == documento);
        }

        public async Task<int> CreateAsync(DocumentoInvEnc documentoInvEnc)
        {
            return await _dbContext.InsertAsync(documentoInvEnc);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new DocumentoInvEnc
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<DocumentoInvEnc?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<DocumentoInvEnc>(id);
        }

        public async Task<ICollection<DocumentoInvEnc>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<DocumentoInvEnc>(page, rows);
        }

        public async Task<int> UpdateAsync(DocumentoInvEnc documentoInvEnc)
        {
            await _dbContext.UpdateAsync(documentoInvEnc,Mapper);
            return documentoInvEnc.Id;
        }
    }
}
