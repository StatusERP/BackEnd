using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS
{
    public interface IZonaRepository
    {
        Task<ICollection<Zona>> GetCollectionAsync(); 
        Task<Zona?> GetByIdAsync(int id);
        Task<Zona?> BuscarCodZonaAsync(string codZona);
        Task<int> CreateAsync(Zona zona);
        Task<int> UpdateAsync(Zona zona);
        Task<int> DeleteAsync(int id,string userId);
    }    
}
