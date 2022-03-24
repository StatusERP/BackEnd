using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface IConsecutivoUsuarioService
{
    Task<BaseResponseGeneric<ICollection<ConsecutivoUsuario>>> GetAsync( int page, int rows);
    Task<BaseResponseGeneric<ConsecutivoUsuario>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoConsecutivoUsuario request,string userId, string codConsecutivoUsuario);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoConsecutivoUsuario request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}