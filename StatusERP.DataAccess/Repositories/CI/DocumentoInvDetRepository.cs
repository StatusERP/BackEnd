using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class DocumentoInvDetRepository : StatusERPContextBase<DocumentoInvDet>, IDocumentoInvDetRepository
    {

        public DocumentoInvDetRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<DocumentoInvDet?> BuscarDocumentoInvDetAsync(string paquete, string documento, int linea)
        {
            return await _dbContext.DocumentosInvDet
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.PaqueteInventario == paquete && t.DocumentoInv == documento && t.LineaDocInv == linea);
        }

        public async Task<int> CreateAsync(DocumentoInvDet documentoInvDet)
        {
            return await _dbContext.InsertAsync(documentoInvDet);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new DocumentoInvDet
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<DocumentoInvDet?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<DocumentoInvDet>(id);
        }

        public async Task<ICollection<DocumentoInvDet>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<DocumentoInvDet>(page, rows);
        }

        public async Task<int> UpdateAsync(DocumentoInvDet documentoInvDet)
        {
            await _dbContext.UpdateAsync(documentoInvDet,Mapper);
            return documentoInvDet.Id;
        }
    }
}
