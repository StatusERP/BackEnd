using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface IMovInventarioDetRepository
    {
        Task<ICollection<MovInventarioDet>> GetCollectionAsync(int page, int rows);
        Task<MovInventarioDet?> GetByIdAsync(int id);
        Task<MovInventarioDet?> BuscarMovInventarioDetAsync(int movInventarioEncId, int consecutivo);
        Task<int> CreateAsync(MovInventarioDet movInventarioDet);
        Task<int> UpdateAsync(MovInventarioDet movInventarioDet);
        Task<int> DeleteAsync(int id, string userId);
    }
}
