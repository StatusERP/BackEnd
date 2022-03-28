using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS.Interfaces;

public interface IDocTributarioRepository
{
    Task<ICollection<DocTributario>> GetCollectionAsync(int page, int rows); 
    Task<DocTributario?> GetByIdAsync(int id);
    Task<int> CreateAsync(DocTributario  docTributario);
    Task<int> UpdateAsync(DocTributario docTributario);
    Task<int> DeleteAsync(int id,string userId);
    Task<DocTributario?> BuscarDocTributarioAsync(string codDocTributario);
}