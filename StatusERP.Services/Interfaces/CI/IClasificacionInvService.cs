using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;


namespace StatusERP.Services.Interfaces.CI
{
    public interface IClasificacionInvService
    {
        Task<BaseResponseGeneric<ICollection<ClasificacionInv>>> GetAsync(int page, int rows, string userId);

        Task<BaseResponseGeneric<ClasificacionInv>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoClasificacionInv request, string userId, string codClasificacion);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoClasificacionInv request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}

