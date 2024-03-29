﻿using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface IRutaService
{
    Task<BaseResponseGeneric<ICollection<Ruta>>> GetAsync(string userId);
    Task<BaseResponseGeneric<Ruta>> GetByIdAsync(int id);

    Task<BaseResponseGeneric<int>> CreateAsync(DtoRuta request,string userId, string codRuta);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoRuta request , string userId);

    Task<BaseResponseGeneric<int>> DeleteAsync(int id,string userId);
}