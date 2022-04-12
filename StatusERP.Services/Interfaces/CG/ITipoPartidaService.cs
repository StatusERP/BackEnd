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
       
>>>>>>> 343e921f8bd3599af8b7c54480f909b21c51bdf7
        Task<BaseResponseGeneric<int>> CreateAsync(DtoTipoPartida request, string userId, string codTipoPartida);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoTipoPartida request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}

