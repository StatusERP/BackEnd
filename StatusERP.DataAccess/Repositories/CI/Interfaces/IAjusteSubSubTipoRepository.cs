using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface IAjusteSubSubTipoRepository
    {
        Task<ICollection<AjusteSubSubTipo>> GetCollectionAsync();
        Task<AjusteSubSubTipo?> GetByIdAsync(int id);
        Task<AjusteSubSubTipo?> BuscarAjusteSubSubTipoAsync(string AjusteConfig, string SubSubTipo);
        Task<int> CreateAsync(AjusteSubSubTipo ajusteSubSubTipo);
        Task<int> UpdateAsync(AjusteSubSubTipo ajusteSubSubTipo);
        Task<int> DeleteAsync(int id, string userId);
    }
}