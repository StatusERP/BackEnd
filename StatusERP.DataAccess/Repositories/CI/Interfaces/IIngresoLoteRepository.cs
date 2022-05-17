using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface IIngresoLoteRepository
    {
        Task<ICollection<IngresoLote>> GetCollectionAsync(int page, int rows);
        Task<IngresoLote?> GetByIdAsync(int id);
        Task<IngresoLote?> BuscarIngresoLoteAsync(int articulo, int lote, int secuenciaLote);
        Task<int> CreateAsync(IngresoLote ingresoLote);
        Task<int> UpdateAsync(IngresoLote ingresoLote);
        Task<int> DeleteAsync(int id, string userId);
    }
}
