using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;


namespace StatusERP.Services.Interfaces.CI
{
    public interface ITipoPagoService
    {
        Task<BaseResponseGeneric<ICollection<TipoPago>>> GetAsync(int page, int rows, string userId);

        Task<BaseResponseGeneric<TipoPago>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoTipoPago request, string userId, string codTipoPago);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoTipoPago request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}
