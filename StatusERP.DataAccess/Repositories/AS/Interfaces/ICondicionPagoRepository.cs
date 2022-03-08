using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS.Interfaces;

public interface ICondicionPagoRepository
{
    Task<ICollection<CondicionPago>> GetCollectionAsync(int page, int rows); 
    Task<CondicionPago?> GetByIdAsync(int id);
    Task<int> CreateAsync(CondicionPago condicionPago);
    Task<int> UpdateAsync(CondicionPago condicionPago);
    Task<int> DeleteAsync(int id,string userId);
}