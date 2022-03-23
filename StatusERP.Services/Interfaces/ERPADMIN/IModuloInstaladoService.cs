using StatusERP.Dto.Request.ERPADMIN;
using StatusERP.Dto.Response;
using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Services.Interfaces.ERPADMIN;

public interface IModuloInstaladoService
{
    Task<BaseResponseGeneric<ICollection<ModuloInstalado>>> GetAsync( int conjunto);
    Task<BaseResponseGeneric<ModuloInstalado>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoModuloInstalado request,string userId);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoModuloInstalado request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}