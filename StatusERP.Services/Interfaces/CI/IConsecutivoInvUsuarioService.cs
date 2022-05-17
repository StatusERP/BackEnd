using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;


namespace StatusERP.Services.Interfaces.CI
{
    public interface IConsecutivoInvUsuarioService
    {
        Task<BaseResponseGeneric<ICollection<ConsecutivoInvUsuario>>> GetAsync(int page, int rows, string userId);

        Task<BaseResponseGeneric<ConsecutivoInvUsuario>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoConsecutivoInvUsuario request, string userId, int consecutivo, int usuario);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoConsecutivoInvUsuario request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}
