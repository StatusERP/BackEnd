using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS.Interfaces;

public interface IMonedaRepository
{
    Task<ICollection<Moneda>> GetCollectionAsync(int page, int rows); 
    Task<Moneda?> GetByIdAsync(int id);
    Task<int> CreateAsync(Moneda moneda );
    Task<int> UpdateAsync(Moneda moneda);
    Task<int> DeleteAsync(int id,string userId);
}