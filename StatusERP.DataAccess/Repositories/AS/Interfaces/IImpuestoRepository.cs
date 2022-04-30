using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS.Interfaces
{
    public interface IImpuestoRepository
    {
        Task<int> CreateAsync(Impuesto Impuesto);
        Task<Impuesto?> BuscarCodImpuestoAsync(string codImpuesto);
        Task<Impuesto?> GetByIdAsync(int id);
        Task<ICollection<Impuesto>> GetCollectionAsync(int page, int rows);
        Task<int> UpdateAsync(Impuesto Impuesto);
        Task<int> DeleteAsync(int id, string userId);
    }
}