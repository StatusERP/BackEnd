using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public interface ICategoriaClienteRepository
{
    Task<ICollection<CategoriaCliente>> GetCollectionAsync();
    
    Task<CategoriaCliente?> GetByIdAsync(int id);
    
    Task<CategoriaCliente?> BuscarCodCategoriaClienteAsync(string codCategoriaCliente);
    
    Task<int> CreateAsync(CategoriaCliente categoriaCliente);

    Task<int> UpdateAsync(CategoriaCliente categoriaCliente);
    
    Task<int> DeleteAsync(int id, string userId);
}