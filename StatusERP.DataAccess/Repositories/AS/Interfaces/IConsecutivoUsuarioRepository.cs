using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS.Interfaces;

public interface IConsecutivoUsuarioRepository
{
    Task<ICollection<ConsecutivoUsuario>> GetCollectionAsync(int page, int rows); 
    Task<ConsecutivoUsuario?> GetByIdAsync(int id);
    Task<int> CreateAsync(ConsecutivoUsuario consecutivoUsuario);
    Task<int> UpdateAsync(ConsecutivoUsuario consecutivoUsuario);
    Task<int> DeleteAsync(int id,string userId);
    Task<ConsecutivoUsuario?> BuscarCodConsecutivoUsuarioAsync(string codConsecutivoUsuario);
}