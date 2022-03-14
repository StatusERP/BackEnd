using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;

public interface IAccionRepository
{
    Task<ICollection<Accion>> GetCollectionAsync(int page, int rows); 
    Task<Accion?> GetByIdAsync(int id);
    Task<int> CreateAsync(Accion accion);
    Task<int> UpdateAsync(Accion accion);
    Task<int> DeleteAsync(int id,string userId);
}