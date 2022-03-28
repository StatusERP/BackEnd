using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS
{
    public interface IRutaRepository
    {
        Task<ICollection<Ruta>> GetCollectionAsync(int page, int rows); 
        Task<Ruta?> GetByIdAsync(int id);
        Task<int> CreateAsync(Ruta ruta);
        Task<int> UpdateAsync(Ruta ruta);
        Task<int> DeleteAsync(int id,string userId);
        Task<Ruta?> BuscarCodRutaAsync(string codRuta);
    }
}