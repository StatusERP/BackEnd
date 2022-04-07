using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public interface IMayorAuditoriaRepository
    {
        Task<ICollection<MayorAuditoria>> GetCollectionAsync(int page, int rows);
        Task<MayorAuditoria?> GetByIdAsync(int id);
        Task<int> CreateAsync(MayorAuditoria MayorAuditoria);
        Task<int> UpdateAsync(MayorAuditoria MayorAuditoria);
        Task<int> DeleteAsync(int id, string userId);
    }
}