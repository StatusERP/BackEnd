using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public interface ICuadreAuxiliarRepository
    {
        Task<ICollection<CuadreAuxiliar>> GetCollectionAsync(int page, int rows);
        Task<CuadreAuxiliar?> GetByIdAsync(int id);
        Task<int> CreateAsync(CuadreAuxiliar CuadreAuxiliar);
        Task<int> UpdateAsync(CuadreAuxiliar CuadreAuxiliar);
        Task<int> DeleteAsync(int id, string userId);
    }
}
