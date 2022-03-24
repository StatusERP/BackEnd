using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface IUsuarioBodegaService
{
    Task<BaseResponseGeneric<ICollection<UsuarioBodega>>> GetAsync( int page, int rows);
    Task<BaseResponseGeneric<UsuarioBodega>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoUsuarioBodega request,string userId,int bodegaId);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoUsuarioBodega request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}