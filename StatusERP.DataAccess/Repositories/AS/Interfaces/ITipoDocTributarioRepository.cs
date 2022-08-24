using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS

{
    public interface ITipoDocTributarioRepository
    {
        Task<ICollection<TipoDocTributario>> GetCollectionAsync();
        Task<TipoDocTributario?> GetByIdAsync(int id);
        Task<TipoDocTributario?> BuscarTipoDocTributarioAsync(string CodTipoDT);
        Task<int> CreateAsync(TipoDocTributario tipoDocTributario);
        Task<int> UpdateAsync(TipoDocTributario tipoDocTributario);
        Task<int> DeleteAsync(int id, string userId);
    }
}
