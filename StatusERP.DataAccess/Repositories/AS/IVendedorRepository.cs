using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS
{
    public interface IVendedorRepository
    {
        Task<ICollection<Vendedor>> GetCollectionAsync(int page, int rows); 
        Task<Vendedor?> GetByIdAsync(int id);
        Task<int> CreateAsync(Vendedor vendedor);
        Task<int> UpdateAsync(Vendedor vendedor);
        Task<int> DeleteAsync(int id,string userId);

    }
}
