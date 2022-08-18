using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS
{
    public interface IDetalleDireccionRepository
    {
        Task<ICollection<DetalleDireccion>> GetCollectionAsync();
        Task<DetalleDireccion?> GetByIdAsync(int id);
        Task<int> CreateAsync(DetalleDireccion detalleDireccion);
        Task<int> UpdateAsync(DetalleDireccion detalleDireccion);
        Task<int> DeleteAsync(int id, string userId);
        Task<DetalleDireccion?> BuscarCodDetalleDireccionAsync(int codDetalleDireccion);
    }
}