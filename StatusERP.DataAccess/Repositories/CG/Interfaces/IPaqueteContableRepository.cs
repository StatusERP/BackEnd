using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public interface IPaqueteContableRepository
    {
        Task<ICollection<PaqueteContable>> GetCollectionAsync(int page, int rows);
        Task<PaqueteContable?> GetByIdAsync(int id);
        Task<PaqueteContable?> BuscarCodPaqueteContableAsync(string codPaqueteContable);
        Task<int> CreateAsync(PaqueteContable PaqueteContable);
        Task<int> UpdateAsync(PaqueteContable PaqueteContable);
        Task<int> DeleteAsync(int id, string userId);
    }
}