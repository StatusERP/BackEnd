using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface ICategoriaClienteService
{
    Task<BaseResponseGeneric<ICollection<CategoriaCliente>>> GetAsync(int page, int rows, string userId);

    Task<BaseResponseGeneric<CategoriaCliente>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoCategoriaCliente request, string userId, string codCategoriaCliente);

    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoCategoriaCliente request, string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
}