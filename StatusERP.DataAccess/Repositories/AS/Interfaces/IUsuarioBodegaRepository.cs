using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS.Interfaces;

public interface IUsuarioBodegaRepository
{
    Task<ICollection<UsuarioBodega>> GetCollectionAsync(int page, int rows); 
    Task<UsuarioBodega?> GetByIdAsync(int id);
    Task<int> CreateAsync(UsuarioBodega usuarioBodega);
    Task<int> UpdateAsync(UsuarioBodega usuarioBodega);
    Task<int> DeleteAsync(int id,string userId);
    Task<UsuarioBodega?> BuscarUsuarioBodegaAsync(string usuario,int bodegaId);
}