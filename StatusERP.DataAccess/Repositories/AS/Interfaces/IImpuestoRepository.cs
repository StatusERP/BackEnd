using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS.Interfaces
{
    public interface IImpuestoRepository
    {
        Task<ICollection<Impuesto>> GetCollectionAsync(int page, int rows);
        Task<Localizacion?> GetByIdAsync(int id);
        Task<int> CreateAsync(Impuesto Impuesto);
        Task<int> UpdateAsync(Impuesto Impuesto);
        Task<int> DeleteAsync(int id, string userId);

        Task<Localizacion?> BuscarCodImpuestoAsync(string codLocalizacion);
    }
}