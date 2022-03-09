using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public interface ISucursalesRepository
{
    Task<ICollection<Sucursal>> GetCollectionAsync(int page, int rows); 
    Task<Sucursal?> GetByIdAsync(int id);
    Task<int> CreateAsync(Sucursal sucursal);
    Task<int> UpdateAsync(Sucursal sucursal);
    Task<int> DeleteAsync(int id,string userId);
}