using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.Services.Interfaces.FA;

public interface IDireccEmbarqueService
{
    Task<BaseResponseGeneric<ICollection<DireccEmbarque>>> GetAsync(string userId);
    Task<BaseResponseGeneric<DireccEmbarque>> GetByIdAsync(int id);
    Task<BaseResponseGeneric<int>> CreateAsync(DtoDireccEmbarque request, string userId, int ClienteId, string Direccion);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoDireccEmbarque request, string userId);
    Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
}