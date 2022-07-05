using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface IExistenciaLoteRepository
    {
        Task<ICollection<ExistenciaLote>> GetCollectionAsync(int page, int rows);
        Task<ExistenciaLote?> GetByIdAsync(int id);
        Task<ExistenciaLote?> BuscarExistenciaLoteAsync(int bodegaId, int articuloId, int localizacionId, int loteId);
        Task<int> CreateAsync(ExistenciaLote existenciaLote);
        Task<int> UpdateAsync(ExistenciaLote existenciaLote);
        Task<int> DeleteAsync(int id, string userId);
    }
}
