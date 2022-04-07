using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public interface IDiarioEncRepository
    {
        Task<ICollection<DiarioEnc>> GetCollectionAsync(int page, int rows);
        Task<DiarioEnc?> GetByIdAsync(int id);
        Task<DiarioEnc?> BuscarCodDiarioEncAsync(string codDiarioEnc);
        Task<int> CreateAsync(DiarioEnc DiarioEnc);
        Task<int> UpdateAsync(DiarioEnc DiarioEnc);
        Task<int> DeleteAsync(int id, string userId);
    }
}