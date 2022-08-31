using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Repositories.FA.Interfaces;

public interface IEscalaBonifRepository
{
    Task<ICollection<EscalaBonif>> GetCollectionAsync();
    Task<EscalaBonif?> GetByIdAsync(int id);
    Task<int> CreateAsync(EscalaBonif escalaBonif);
    Task<int> UpdateAsync(EscalaBonif escalaBonif);
    Task<int> DeleteAsync(int id, string userId);
    Task<EscalaBonif?> BuscarNumEscalaBonifAsync(int versionNivelId, int articuloId, int numEscalaBonif, int versionBonif);
}