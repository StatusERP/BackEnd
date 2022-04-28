using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface ICategoriaArticuloRepository
    {
        Task<ICollection<CategoriaArticulo>> GetCollectionAsync(int page, int rows);
        Task<CategoriaArticulo?> GetByIdAsync(int id);
        Task<CategoriaArticulo?> BuscarCodCategoriaArticuloAsync(string CodCategoriaArticulo);
        Task<int> CreateAsync(CategoriaArticulo CategoriaArticulo);
        Task<int> UpdateAsync(CategoriaArticulo CategoriaArticulo);
        Task<int> DeleteAsync(int id, string userId);
    }
}
