using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS

{
    public interface IMonedaRepository
    {
        Task<ICollection<Moneda>> GetCollectionAsync();
        Task<Moneda?> GetByIdAsync(int id);
        Task<Moneda?> BuscarCodMonedaAsync(string CodMoneda);
        Task<int> CreateAsync(Moneda moneda);
        Task<int> UpdateAsync(Moneda moneda);
        Task<int> DeleteAsync(int id, string userId);
    }
}
