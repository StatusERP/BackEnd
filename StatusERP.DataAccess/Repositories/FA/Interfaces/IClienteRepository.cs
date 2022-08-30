using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Repositories.FA.Interfaces;

public interface IClienteRepository
{
    Task<ICollection<Cliente>> GetCollectionAsync();
    Task<Cliente?> GetByIdAsync(int id);
    Task<int> CreateAsync(Cliente cliente);
    Task<int> UpdateAsync(Cliente cliente);
    Task<int> DeleteAsync(int id, string userId);
    Task<Cliente?> BuscarCodClienteAsync(string codCliente);
}