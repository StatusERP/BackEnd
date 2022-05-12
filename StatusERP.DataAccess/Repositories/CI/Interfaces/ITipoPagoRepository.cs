using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface ITipoPagoRepository
    {
        Task<ICollection<TipoPago>> GetCollectionAsync(int page, int rows);
        Task<TipoPago?> GetByIdAsync(int id);
        Task<TipoPago?> BuscarCodTipoPagoAsync(string codTipoPago);
        Task<int> CreateAsync(TipoPago tipoPago);
        Task<int> UpdateAsync(TipoPago tipoPago);
        Task<int> DeleteAsync(int id, string userId);
    }
}
