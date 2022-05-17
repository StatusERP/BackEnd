using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface IUsuarioAjusteInvRepository
    {
        Task<ICollection<UsuarioAjusteInv>> GetCollectionAsync(int page, int rows);
        Task<UsuarioAjusteInv?> GetByIdAsync(int id);
        Task<UsuarioAjusteInv?> BuscarUsuarioAjusteInvAsync(string usuario, string ajusteConfig);
        Task<int> CreateAsync(UsuarioAjusteInv usuarioAjusteInv);
        Task<int> UpdateAsync(UsuarioAjusteInv usuarioAjusteInv);
        Task<int> DeleteAsync(int id, string userId);
    }
}