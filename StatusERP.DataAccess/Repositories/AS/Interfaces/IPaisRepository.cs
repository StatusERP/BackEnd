using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS.Interfaces
{
    public interface IPaisRepository
    {
        Task<ICollection<Pais>> GetCollectionAsync();
        Task<Pais?> GetByIdAsync(int id);
        Task<Pais?> BuscarCodPaisAsync(string codPais);
        Task<int> CreateAsync(Pais pais);
        Task<int> UpdateAsync(Pais pais);
        Task<int> DeleteAsync(int id, string userId);
      
    }
}
