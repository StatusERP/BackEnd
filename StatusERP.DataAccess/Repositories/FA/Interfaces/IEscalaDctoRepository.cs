using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Repositories.FA.Interfaces;

public interface IEscalaDctoRepository
{
    Task<ICollection<EscalaDcto>> GetCollectionAsync();
    Task<EscalaDcto?> GetByIdAsync(int id);
    Task<int> CreateAsync(EscalaDcto escalaDcto);
    Task<int> UpdateAsync(EscalaDcto escalaDcto);
    Task<int> DeleteAsync(int id, string userId);
    Task<EscalaDcto?> BuscarNumEscalaDctoAsync(int versionNivelId, int articuloId, int numEscalaDcto, int versionDcto);
}