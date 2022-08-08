using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;


namespace StatusERP.Services.Interfaces.CI
{
    public interface IMovInventarioEncService
    {
        Task<BaseResponseGeneric<ICollection<MovInventarioEnc>>> GetAsync(int page, int rows, string userId);

        Task<BaseResponseGeneric<MovInventarioEnc>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoMovInventarioEnc request, string userId);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoMovInventarioEnc request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}