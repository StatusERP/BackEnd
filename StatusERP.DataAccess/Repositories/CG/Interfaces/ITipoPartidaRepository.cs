using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public interface ITipoPartidaRepository
    {
        Task<ICollection<TipoPartida>> GetCollectionAsync(int page, int rows);
        Task<TipoPartida?> GetByIdAsync(int id);
        Task<TipoPartida?> BuscarCodTipoPartidaAsync(string codTipoPartida);
        Task<int> CreateAsync(TipoPartida tipoPartida);
        Task<int> UpdateAsync(TipoPartida tipoPartida);
        Task<int> DeleteAsync(int id, string userId);
    }
}
