using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface ITipoTarjetaService
{
    Task<BaseResponseGeneric<ICollection<TipoTarjeta>>> GetAsync(string userId);

    Task<BaseResponseGeneric<TipoTarjeta>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoTipoTarjeta request, string userId, string codTipoTarjeta);

    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoTipoTarjeta request, string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
}
