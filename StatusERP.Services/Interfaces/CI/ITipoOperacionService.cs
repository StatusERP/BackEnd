using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;


namespace StatusERP.Services.Interfaces.CI
{
    public interface ITipoOperacionService
    {
        Task<BaseResponseGeneric<ICollection<TipoOperacion>>> GetAsync(int page, int rows, string userId);

        Task<BaseResponseGeneric<TipoOperacion>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoTipoOperacion request, string userId, string codTipoOperacion);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoTipoOperacion request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}

