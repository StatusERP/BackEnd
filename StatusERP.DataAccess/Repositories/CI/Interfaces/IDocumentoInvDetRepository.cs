using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface IDocumentoInvDetRepository
    {
        Task<ICollection<DocumentoInvDet>> GetCollectionAsync(int page, int rows);
        Task<DocumentoInvDet?> GetByIdAsync(int id);
        Task<DocumentoInvDet?> BuscarDocumentoInvDetAsync(int paquete, string documento, int linea);
        Task<int> CreateAsync(DocumentoInvDet documentoInvDet);
        Task<int> UpdateAsync(DocumentoInvDet documentoInvDet);
        Task<int> DeleteAsync(int id, string userId);
    }
}

