using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS
{
    public interface IMetodoPagoService
    {
        Task<BaseResponseGeneric<ICollection<MetodoPago>>> GetAsync(string userId);
        Task<BaseResponseGeneric<MetodoPago>> GetByIdAsync(int id);
        Task<BaseResponseGeneric<int>> CreateAsync(DtoMetodoPago request, string userId, string codMetodoPago);
        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoMetodoPago request, string userId);
        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);

    }

}

