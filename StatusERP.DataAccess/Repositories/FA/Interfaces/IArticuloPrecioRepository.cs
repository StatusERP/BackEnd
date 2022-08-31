using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Repositories.FA.Interfaces;

public interface IArticuloPrecioRepository
{
    Task<ICollection<ArticuloPrecio>> GetCollectionAsync();
    Task<ArticuloPrecio?> GetByIdAsync(int id);
    Task<int> CreateAsync(ArticuloPrecio articuloPrecio);
    Task<int> UpdateAsync(ArticuloPrecio articuloPrecio);
    Task<int> DeleteAsync(int id, string userId);
    Task<ArticuloPrecio?> BuscarArticuloPrecioAsync(int VersionNivelId, int ArticuloId, int VersionArticulo);
}