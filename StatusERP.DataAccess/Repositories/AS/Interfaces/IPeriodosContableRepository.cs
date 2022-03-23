using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS.Interfaces;

public interface IPeriodosContableRepository
{
    Task<ICollection<PeriodoContable>> GetCollectionAsync(int page, int rows); 
    Task<PeriodoContable?> GetByIdAsync(int id);
    Task<int> CreateAsync(PeriodoContable periodoContable);
    Task<int> UpdateAsync(PeriodoContable periodoContable);
    Task<int> DeleteAsync(int id,string userId);
}