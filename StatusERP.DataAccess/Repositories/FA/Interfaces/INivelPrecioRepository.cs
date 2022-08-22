using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Repositories.FA.Interfaces;

public interface INivelPrecioRepository
{
    Task<ICollection<NivelPrecio>> GetCollectionAsync(); 
    Task<NivelPrecio?> GetByIdAsync(int id);
    Task<int> CreateAsync(NivelPrecio nivelPrecio);
    Task<int> UpdateAsync(NivelPrecio nivelPrecio);
    Task<int> DeleteAsync(int id,string userId);
    Task<NivelPrecio?> BuscarCodNivelPrecioAsync(string codNivelPrecio);
}