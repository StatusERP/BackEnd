using StatusERP.Dto.Request.ERPADMIN;
using StatusERP.Dto.Response;
using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Services.Interfaces.ERPADMIN;

public interface IMenbresiaService
{
    Task<BaseResponseGeneric<ICollection<Membresia>>> GetAsync( int page, int rows);
    Task<BaseResponseGeneric<Membresia>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoMenbresia request,string userId);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoMenbresia request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}