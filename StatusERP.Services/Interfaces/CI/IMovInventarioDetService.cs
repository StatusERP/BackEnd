using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;


namespace StatusERP.Services.Interfaces.CI
{
    public interface IMovInventarioDetService
    {
        Task<BaseResponseGeneric<ICollection<MovInventarioDet>>> GetAsync(int page, int rows, string userId);

        Task<BaseResponseGeneric<MovInventarioDet>> GetByIdAsync(int id);

        //Task<BaseResponseGeneric<int>> CreateAsync(DtoMovInventarioDet request, DtoExistenciaBodega ebrequest, DtoExistenciaLote elrequest, string userId, int movInventarioEncId, int articuloId);
        Task<BaseResponseGeneric<int>> CreateAsync(DtoMovInventarioDet request, string userId, int movInventarioEncId, int articuloId);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoMovInventarioDet request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}