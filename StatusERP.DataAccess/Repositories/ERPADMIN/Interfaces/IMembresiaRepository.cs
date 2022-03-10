using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;

public interface IMembresiaRepository
{
    Task<ICollection<Membresia>> GetCollectionAsync(int page, int rows); 
    Task<Membresia?> GetByIdAsync(int id);
    Task<int> CreateAsync(Membresia membresia);
    Task<int> UpdateAsync(Membresia membresia);
    Task<int> DeleteAsync(int id,string userId);
}