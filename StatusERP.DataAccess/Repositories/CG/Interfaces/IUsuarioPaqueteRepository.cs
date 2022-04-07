using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public interface IUsuarioPaqueteRepository
    {
        Task<ICollection<UsuarioPaquete>> GetCollectionAsync(int page, int rows);
        Task<UsuarioPaquete?> GetByIdAsync(int id);
        Task<int> CreateAsync(UsuarioPaquete UsuarioPaquete);
        Task<int> UpdateAsync(UsuarioPaquete UsuarioPaquete);
        Task<int> DeleteAsync(int id, string userId);
    }
}