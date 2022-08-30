using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.Services.Interfaces.FA;

public interface IClienteService
{
    Task<BaseResponseGeneric<ICollection<Cliente>>> GetAsync(int page, int rows, string userId);
    Task<BaseResponseGeneric<Cliente>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoCliente request, string userId, string codCliente);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoCliente request, string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
}