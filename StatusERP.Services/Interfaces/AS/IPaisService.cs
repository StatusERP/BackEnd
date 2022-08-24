using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS
{
    public interface IPaisService
    {
        Task<BaseResponseGeneric<ICollection<Pais>>> GetAsync(string userId);
        Task<BaseResponseGeneric<Pais>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoPais request, string userId, string codPais);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoPais request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}
