using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface ILoteRepository
    {
        Task<ICollection<Lote>> GetCollectionAsync();
        Task<Lote?> GetByIdAsync(int id);
        Task<Lote?> BuscarLoteArticuloAsync(string CodLote, int ArticuloId);
        Task<int> CreateAsync(Lote lote);
        Task<int> UpdateAsync(Lote lote);
        Task<int> DeleteAsync(int id, string userId);
    }
}
