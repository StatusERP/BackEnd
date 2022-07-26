using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface IDocumentoInvEncRepository
    {
        Task<ICollection<DocumentoInvEnc>> GetCollectionAsync(int page, int rows);
        Task<DocumentoInvEnc?> GetByIdAsync(int id);
        Task<DocumentoInvEnc?> BuscarDocumentoInvEncAsync(int paquete, string documento);
        Task<int> CreateAsync(DocumentoInvEnc documentoInvEnc);
        Task<int> UpdateAsync(DocumentoInvEnc documentoInvEnc);
        Task<int> DeleteAsync(int id, string userId);
    }
}
