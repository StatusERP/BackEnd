using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface ITipoOperacionRepository
    {
        Task<ICollection<TipoOperacion>> GetCollectionAsync(int page, int rows);
        Task<TipoOperacion?> GetByIdAsync(int id);
        Task<TipoOperacion?> BuscarCodTipoOperacionAsync(string codTipoOperacion);
        Task<int> CreateAsync(TipoOperacion tipoOperacion);
        Task<int> UpdateAsync(TipoOperacion tipoOperacion);
        Task<int> DeleteAsync(int id, string userId);
    }
}
