using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Repositories.FA.Interfaces;

public interface IVersionNivelPrecioRepository
{
    Task<ICollection<VersionNivelPrecio>> GetCollectionAsync();
    Task<VersionNivelPrecio?> GetByIdAsync(int id);
    Task<int> CreateAsync(VersionNivelPrecio versionNivelPrecio);
    Task<int> UpdateAsync(VersionNivelPrecio versionNivelPrecio);
    Task<int> DeleteAsync(int id, string userId);
    Task<VersionNivelPrecio?> BuscarVersionNivelPrecioIdAsync(int NivelPrecioId, int version);
}