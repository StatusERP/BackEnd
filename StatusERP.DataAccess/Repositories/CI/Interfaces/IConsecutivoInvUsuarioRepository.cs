using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface IConsecutivoInvUsuarioRepository
    {
        Task<ICollection<ConsecutivoInvUsuario>> GetCollectionAsync();
        Task<ConsecutivoInvUsuario?> GetByIdAsync(int id);
        Task<ConsecutivoInvUsuario?> BuscarConsecutivoInvUsuarioAsync(int consecutivo, int usuario);
        Task<int> CreateAsync(ConsecutivoInvUsuario consecutivoInvUsuario );
        Task<int> UpdateAsync(ConsecutivoInvUsuario consecutivoInvUsuario);
        Task<int> DeleteAsync(int id, string userId);
    }
}
