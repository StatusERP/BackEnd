using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;


namespace StatusERP.Services.Interfaces.CI
{
    public interface IExistenciaBodegaService
    {
        Task<BaseResponseGeneric<ICollection<ExistenciaBodega>>> GetAsync(int page, int rows, string userId);

        Task<BaseResponseGeneric<ExistenciaBodega>> GetByIdAsync(int id);
        Task<BaseResponseGeneric<ICollection<ExistenciaBodega>>> GetByIdArticuloAsync(int articuloId);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoExistenciaBodega request, string userId, int bodegaId, int articuloId);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoExistenciaBodega request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}