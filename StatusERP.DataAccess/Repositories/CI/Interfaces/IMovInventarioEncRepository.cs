using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface IMovInventarioEncRepository
    {
        Task<ICollection<MovInventarioEnc>> GetCollectionAsync(int page, int rows);
        Task<MovInventarioEnc ?> GetByIdAsync(int id);
        Task<MovInventarioEnc?> BuscarIdMovInventarioEncAsync(int Id);
        Task<int> CreateAsync(MovInventarioEnc movInventarioEnc);
        Task<int> UpdateAsync(MovInventarioEnc movInventarioEnc);
        Task<int> DeleteAsync(int id, string userId);
    }
}