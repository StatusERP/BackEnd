using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;

public interface IConjuntoRepository
{
    Task<ICollection<Conjunto>> GetCollectionAsync(int page, int rows); 
    Task<Conjunto?> GetByIdAsync(int id);
    Task<int> CreateAsync(Conjunto conjunto);
    Task<int> UpdateAsync(Conjunto conjunto);
    Task<int> DeleteAsync(int id,string userId);
}