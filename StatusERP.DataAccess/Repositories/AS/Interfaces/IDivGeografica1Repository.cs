using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS.Interfaces;

public interface IDivGeografica1Repository
{
    Task<ICollection<DivGeografica1>> GetCollectionAsync(int page, int rows); 
    Task<DivGeografica1?> GetByIdAsync(int id);
    Task<int> CreateAsync(DivGeografica1  divGeografica1 );
    Task<int> UpdateAsync(DivGeografica1 divGeografica1);
    Task<int> DeleteAsync(int id,string userId);
    Task<DivGeografica1?> BuscarCodDivGeografica1Async(string codDivGeografica);
}