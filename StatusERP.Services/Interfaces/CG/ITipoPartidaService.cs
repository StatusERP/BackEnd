using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.Services.Interfaces.CG
{
    public interface ITipoPartidaService
    {

<<<<<<< HEAD
        Task<BaseResponseGeneric<ICollection<TipoPartida>>> GetAsync(int page, int rows);
        Task<BaseResponseGeneric<TipoPartida>> GetByIdAsync(int id);
       

=======

        Task<BaseResponseGeneric<ICollection<TipoPartida>>> GetAsync(int page, int rows);
        Task<BaseResponseGeneric<TipoPartida>> GetByIdAsync(int id);
       
<<<<<<< HEAD

=======
>>>>>>> ecccf0a19246c7fdcf8a17940ca6d82865dfa51d
>>>>>>> 00f5247893139259dc62439a7a7ef3d79fd58845
        Task<BaseResponseGeneric<int>> CreateAsync(DtoTipoPartida request, string userId, string codTipoPartida);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoTipoPartida request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}

