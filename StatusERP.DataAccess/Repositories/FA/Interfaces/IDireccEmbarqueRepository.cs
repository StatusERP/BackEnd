using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Repositories.FA.Interfaces;

public interface IDireccEmbarqueRepository
{
    Task<ICollection<DireccEmbarque>> GetCollectionAsync();
    Task<DireccEmbarque?> GetByIdAsync(int id);
    Task<int> CreateAsync(DireccEmbarque direccEmbarque);
    Task<int> UpdateAsync(DireccEmbarque direccEmbarque);
    Task<int> DeleteAsync(int id, string userId);
    Task<DireccEmbarque?> BuscarDireccEmbarqueAsync(int clienteId, string direccion);
}