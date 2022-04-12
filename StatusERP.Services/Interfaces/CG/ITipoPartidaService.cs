using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.Services.Interfaces.CG
{
    public interface ITipoPartidaService
    {
<<<<<<< HEAD

=======
        Task<BaseResponseGeneric<ICollection<TipoPartida>>> GetAsync(int page, int rows);
        Task<BaseResponseGeneric<TipoPartida>> GetByIdAsync(int id);
       
>>>>>>> 1e95b26df6b7338992bd5a05cdc071dcf0db56e2
        Task<BaseResponseGeneric<int>> CreateAsync(DtoTipoPartida request, string userId, string codTipoPartida);

        Task<BaseResponseGeneric<TipoPartida>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<ICollection<TipoPartida>>> GetAsync(int page, int rows);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoTipoPartida request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}

