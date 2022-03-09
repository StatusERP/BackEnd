using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS.Interfaces;

public interface IEntidadFinacieraRepository
{
    Task<ICollection<EntidadFinanciera>> GetCollectionAsync(int page, int rows); 
    Task<EntidadFinanciera?> GetByIdAsync(int id);
    Task<int> CreateAsync(EntidadFinanciera entidadFinanciera);
    Task<int> UpdateAsync(EntidadFinanciera entidadFinanciera);
    Task<int> DeleteAsync(int id,string userId);
}