using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS
{
    public interface ICobradorService
    {
        Task<BaseResponseGeneric<ICollection<Cobrador>>> GetAsync(int page, int rows);
        Task<BaseResponseGeneric<Cobrador>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoCobrador request, string userId);
        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoCobrador request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id);
    }
}
