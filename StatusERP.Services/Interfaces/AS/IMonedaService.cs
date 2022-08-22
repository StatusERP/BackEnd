using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface IMonedaService
{
    Task<BaseResponseGeneric<ICollection<Moneda>>> GetAsync(string userId);
    Task<BaseResponseGeneric<Moneda>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoMoneda request,string userId, string codMoneda);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoMoneda request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}