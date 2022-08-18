using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS

{
    public interface IDireccionRepository
    {
        Task<ICollection<Direccion>> GetCollectionAsync(int page, int rows);
        Task<Direccion?> GetByIdAsync(int id);
        Task<Direccion?> BuscarDireccionAsync(string CodDireccion);
        Task<int> CreateAsync(Direccion direccion);
        Task<int> UpdateAsync(Direccion direccion);
        Task<int> DeleteAsync(int id, string userId);
    }
}
