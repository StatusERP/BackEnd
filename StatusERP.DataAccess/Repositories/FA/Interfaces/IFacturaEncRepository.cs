using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Repositories.FA.Interfaces;

public interface IFacturaEncRepository
{
    Task<ICollection<FacturaEnc>> GetCollectionAsync(); 
    Task<FacturaEnc?> GetByIdAsync(int id);
    Task<int> CreateAsync(FacturaEnc facturaEnc);
    Task<int> UpdateAsync(FacturaEnc facturaEnc);
    Task<int> DeleteAsync(int id,string userId);
    Task<FacturaEnc?> BuscarFacturaEncAsync(string tipoDocumento, string factura);
}