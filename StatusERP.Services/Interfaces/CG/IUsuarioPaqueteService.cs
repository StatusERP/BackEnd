using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;


namespace StatusERP.Services.Interfaces.CG
{
    public interface IUsuarioPaqueteService
    {
        Task<BaseResponseGeneric<ICollection<UsuarioPaquete>>> GetAsync(int page, int rows);

        Task<BaseResponseGeneric<UsuarioPaquete>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoUsuarioPaquete request, string userId, string codUsuarioPaquete);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoUsuarioPaquete request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}