using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS

{
    public interface ICategoriaProveedorRepository
    {
        Task<ICollection<CategoriaProveedor>> GetCollectionAsync(int page, int rows);
        Task<CategoriaProveedor?> GetByIdAsync(int id);
        Task<CategoriaProveedor?> BuscarCodCategoriaProveedorAsync(string CodCategoriaProveedor);
        Task<int> CreateAsync(CategoriaProveedor categoriaProveedor);
        Task<int> UpdateAsync(CategoriaProveedor categoriaProveedor);
        Task<int> DeleteAsync(int id, string userId);
    }
}
