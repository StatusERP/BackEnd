using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.Services.Interfaces.FA;

public interface IFacturaEncService
{
    Task<BaseResponseGeneric<ICollection<FacturaEnc>>> GetAsync( int page, int rows, string userId);
    Task<BaseResponseGeneric<FacturaEnc>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoFacturaEnc request,string userId, string tipoDocumento, string factura);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoFacturaEnc request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}