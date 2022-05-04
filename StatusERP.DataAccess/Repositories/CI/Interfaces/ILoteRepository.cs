using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface ILoteRepository
    {
        Task<ICollection<Lote>> GetCollectionAsync(int page, int rows);
        Task<Lote?> GetByIdAsync(int id);
        Task<Lote?> BuscarCodLoteAsync(string CodLote);
        Task<int> CreateAsync(Lote Lote);
        Task<int> UpdateAsync(Lote Lote);
        Task<int> DeleteAsync(int id, string userId);
    }
}
