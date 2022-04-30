using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface IClasificacionInvRepository
    {
        Task<ICollection<ClasificacionInv>> GetCollectionAsync(int page, int rows);
        Task<ClasificacionInv?> GetByIdAsync(int id);
        Task<ClasificacionInv?> BuscarCodClasificacionInvAsync(string CodClasificacion);
        Task<int> CreateAsync(ClasificacionInv ClasificacionInv);
        Task<int> UpdateAsync(ClasificacionInv ClasificacionInv);
        Task<int> DeleteAsync(int id, string userId);
    }
}