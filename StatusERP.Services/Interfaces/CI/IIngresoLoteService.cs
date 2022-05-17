using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;


namespace StatusERP.Services.Interfaces.CI
{
    public interface IIngresoLoteService
    {
        Task<BaseResponseGeneric<ICollection<IngresoLote>>> GetAsync(int page, int rows, string userId);

        Task<BaseResponseGeneric<IngresoLote>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoIngresoLote request, string userId, int articulo, int lote, int secuenciaLote);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoIngresoLote request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}
