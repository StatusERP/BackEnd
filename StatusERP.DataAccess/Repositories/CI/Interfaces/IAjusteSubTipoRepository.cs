using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface IAjusteSubTipoRepository
    {
        Task<ICollection<AjusteSubTipo>> GetCollectionAsync();
        Task<AjusteSubTipo?> GetByIdAsync(int id);
        Task<AjusteSubTipo?> BuscarAjusteSubTipoAsync(string AjusteConfig, string SubTipo);
        Task<int> CreateAsync(AjusteSubTipo ajusteSubTipo);
        Task<int> UpdateAsync(AjusteSubTipo ajusteSubTipo);
        Task<int> DeleteAsync(int id, string userId);
    }
}
