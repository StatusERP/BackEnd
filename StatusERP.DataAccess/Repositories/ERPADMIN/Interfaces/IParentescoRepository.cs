using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;

public interface IParentescoRepository
{
    Task<ICollection<Parentesco>> GetCollectionAsync(int page, int rows); 
    Task<Parentesco?> GetByIdAsync(int id);
    Task<int> CreateAsync(Parentesco parentesco);
    Task<int> UpdateAsync(Parentesco  parentesco );
    Task<int> DeleteAsync(int id,string userId);
}
