using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public interface IMayorEncRepository
    {
        Task<ICollection<MayorEnc>> GetCollectionAsync(int page, int rows);
        Task<MayorEnc?> GetByIdAsync(int id);
        Task<MayorEnc?> BuscarCodMayorEncAsync(string codMayorEnc);
        Task<int> CreateAsync(MayorEnc MayorEnc);
        Task<int> UpdateAsync(MayorEnc MayorEnc);
        Task<int> DeleteAsync(int id, string userId);
    }
}