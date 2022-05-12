using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI

{
    public interface IExistenciaBodegaRepository
    {
        Task<ICollection<ExistenciaBodega>> GetCollectionAsync(int page, int rows);
        Task<ExistenciaBodega?> GetByIdAsync(int id);
        Task<ExistenciaBodega?> BuscarIdExistenciaBodegaAsync(int articuloId, int bodegaId);
        Task<int> CreateAsync(ExistenciaBodega existenciaBodega);
        Task<int> UpdateAsync(ExistenciaBodega existenciaBodega);
        Task<int> DeleteAsync(int id, string userId);
    }
}