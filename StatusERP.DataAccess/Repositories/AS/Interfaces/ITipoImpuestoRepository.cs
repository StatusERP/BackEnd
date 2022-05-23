using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS
{
    public interface ITipoImpuestoRepository
    {
        Task<ICollection<TipoImpuesto>> GetCollectionAsync(int page, int rows);
        Task<TipoImpuesto?> GetByIdAsync(int id);
        Task<int> CreateAsync(TipoImpuesto tipoImpuesto);
        Task<int> UpdateAsync(TipoImpuesto tipoImpuesto);
        Task<int> DeleteAsync(int id, string userId);
        Task<TipoImpuesto?> BuscarCodTipoImpuestoAsync(string codTipoImpuesto);
    }
}