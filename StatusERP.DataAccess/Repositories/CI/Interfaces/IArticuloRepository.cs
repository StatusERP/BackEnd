using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface IArticuloRepository
    {
        Task<ICollection<Articulo>> GetCollectionAsync(int page, int rows);
        Task<Articulo?> GetByIdAsync(int id);
        Task<Articulo?> BuscarCodArticuloAsync(string CodArticulo);
        Task<int> CreateAsync(Articulo Articulo);
        Task<int> UpdateAsync(Articulo Articulo);
        Task<int> DeleteAsync(int id, string userId);
    }
}
