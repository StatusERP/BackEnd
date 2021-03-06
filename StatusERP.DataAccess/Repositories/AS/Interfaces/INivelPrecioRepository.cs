using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS.Interfaces;

public interface INivelPrecioRepository
{
    Task<ICollection<NivelPrecio>> GetCollectionAsync(int page, int rows); 
    Task<NivelPrecio?> GetByIdAsync(int id);
    Task<int> CreateAsync(NivelPrecio nivelPrecio);
    Task<int> UpdateAsync(NivelPrecio nivelPrecio);
    Task<int> DeleteAsync(int id,string userId);
    Task<NivelPrecio?> BuscarCodNivelPrecioAsync(string codNivelPrecio);
}