using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.Services.Interfaces.CG
{
    public interface ICuadreAuxiliarService
    {
        Task<BaseResponseGeneric<ICollection<CuadreAuxiliar>>> GetAsync(int page, int rows);

        Task<BaseResponseGeneric<CuadreAuxiliar>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoCuadreAuxiliar request, string userId, string codCuadreAuxiliar);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoCuadreAuxiliar request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}