using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;


namespace StatusERP.Services.Interfaces.CI
{
    public interface IExistenciaLoteService
    {
        Task<BaseResponseGeneric<ICollection<ExistenciaLote>>> GetAsync(int page, int rows, string userId);

        Task<BaseResponseGeneric<ExistenciaLote>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoExistenciaLote request, string userId, int bodegaId, int articuloId, int localizacionId, int loteId);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoExistenciaLote request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}


