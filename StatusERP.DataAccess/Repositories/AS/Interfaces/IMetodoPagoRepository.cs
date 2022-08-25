using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS
{
    public interface IMetodoPagoRepository
    {
        Task<ICollection<MetodoPago>> GetCollectionAsync();
        Task<MetodoPago?> GetByIdAsync(int id);
        Task<MetodoPago?> BuscarCodMetodoPagoAsync(string codMetodoPago);
        Task<int> CreateAsync(MetodoPago metodoPago);
        Task<int> UpdateAsync(MetodoPago metodoPago);
        Task<int> DeleteAsync(int id, string userId);
    }
}
