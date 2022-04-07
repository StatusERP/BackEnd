using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public interface IMayorDetRepository
    {
        Task<ICollection<MayorDet>> GetCollectionAsync(int page, int rows);
        Task<MayorDet?> GetByIdAsync(int id);
        Task<int> CreateAsync(MayorDet MayorDet);
        Task<int> UpdateAsync(MayorDet MayorDet);
        Task<int> DeleteAsync(int id, string userId);
    }
}