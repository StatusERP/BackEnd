using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusERP.Services.Implementations.CG
{
    public interface ITipoPartidaService
    {
        Task<BaseResponseGeneric<ICollection<TipoPartida>>> GetAsync(int page, int rows);
        Task<BaseResponseGeneric<TipoPartida>> GetByIdAsync(int id);
       
        Task<BaseResponseGeneric<int>> CreateAsync(DtoTipoPartida request, string userId, string codTipoPartida);
        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoTipoPartida request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}

