using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface IEntidadFinacieraService
{
    Task<BaseResponseGeneric<ICollection<EntidadFinanciera>>> GetAsync( int page, int rows);
    Task<BaseResponseGeneric<EntidadFinanciera>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoEntidadFinaciera request,string userId);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoEntidadFinaciera request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
    
}