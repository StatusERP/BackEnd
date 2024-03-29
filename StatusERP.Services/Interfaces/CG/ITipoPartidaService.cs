﻿using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.Services.Interfaces.CG
{
    public interface ITipoPartidaService
    {

        Task<BaseResponseGeneric<ICollection<TipoPartida>>> GetAsync(int page, int rows, string userId);
        Task<BaseResponseGeneric<TipoPartida>> GetByIdAsync(int id);
       

        Task<BaseResponseGeneric<int>> CreateAsync(DtoTipoPartida request, string userId, string codTipoPartida);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoTipoPartida request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}

