using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;

public interface IModuloInstaladoRepository
{
    Task<ICollection<ModuloInstalado>> GetCollectionAsync(int conjunto); 
    Task<ModuloInstalado?> GetByIdAsync(int id);
    Task<int> CreateAsync(ModuloInstalado moduloInstalado);
    Task<int> UpdateAsync(ModuloInstalado  moduloInstalado );
    Task<int> DeleteAsync(int id,string userId);
}