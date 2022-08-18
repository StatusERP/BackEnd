using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;


namespace StatusERP.Services.Interfaces.AS
{
    public interface IDireccionService
    {
        Task<BaseResponseGeneric<ICollection<Direccion>>> GetAsync(int page, int rows, string userId);

        Task<BaseResponseGeneric<Direccion>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoDireccion request, string userId, string codDireccion);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoDireccion request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}
