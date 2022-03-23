using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS.Interfaces;

public interface ITipoCambioRepository
{
    Task<ICollection<TipoCambio>> GetCollectionAsync(int page, int rows); 
    Task<TipoCambio?> GetByIdAsync(int id);
    Task<int> CreateAsync(TipoCambio tipoCambio);
    Task<int> UpdateAsync(TipoCambio tipoCambio);
    Task<int> DeleteAsync(int id,string userId);
}