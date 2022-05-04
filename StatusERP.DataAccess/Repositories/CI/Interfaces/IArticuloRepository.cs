using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface IArticuloRepository
    {
        Task<ICollection<Articulo>> GetCollectionAsync(int page, int rows);
        Task<Articulo?> GetByIdAsync(int id);
        Task<Articulo?> BuscarCodArticuloAsync(string CodArticulo);
        Task<int> CreateAsync(Articulo articulo);
        Task<int> UpdateAsync(Articulo articulo);
        Task<int> DeleteAsync(int id, string userId);
    }
}
