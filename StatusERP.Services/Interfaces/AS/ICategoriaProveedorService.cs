using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface ICategoriaProveedorService
{
    Task<BaseResponseGeneric<ICollection<CategoriaProveedor>>> GetAsync(int page, int rows, string userId);

    Task<BaseResponseGeneric<CategoriaProveedor>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoCategoriaProveedor request, string userId, string codCategoriaProveedor);

    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoCategoriaProveedor request, string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
}