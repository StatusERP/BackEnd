using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface ISucursalService
{
    Task<BaseResponseGeneric<ICollection<Sucursal>>> GetAsync( int page, int rows);
    Task<BaseResponseGeneric<Sucursal>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoSucursal request,string userId);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoSucursal request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);

}