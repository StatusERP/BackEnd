using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS.Interfaces
{
    public interface ILocalizacionesRepository
    {
        Task<ICollection<Localizacion>> GetCollectionAsync();
        Task<Localizacion?> GetByIdAsync(int id);
        Task<ICollection<Localizacion>> GetByIdBodegaAsync(int id);
        Task<int> CreateAsync( Localizacion localizacion);
        Task<int> UpdateAsync(Localizacion localizacion );
        Task<int> DeleteAsync(int id, string userId);
        Task<Localizacion?> BuscarBodegaLocalizacionAsync(int BodegaId, string codLocalizacion);
    }
}
