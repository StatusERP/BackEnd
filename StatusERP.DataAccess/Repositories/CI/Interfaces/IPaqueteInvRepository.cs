using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface IPaqueteInvRepository
    {
        Task<ICollection<PaqueteInv>> GetCollectionAsync(int page, int rows);
        Task<PaqueteInv?> GetByIdAsync(int id);
        Task<PaqueteInv?> BuscarCodPaqueteInvAsync(string codPaqueteInv);
        Task<int> CreateAsync(PaqueteInv paqueteInv);
        Task<int> UpdateAsync(PaqueteInv paqueteInv);
        Task<int> DeleteAsync(int id, string userId);
    }
}

