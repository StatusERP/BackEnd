﻿using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS;

public interface IGlobalesASService
{
    Task<BaseResponseGeneric<ICollection<GlobalesAS>>> GetAsync(string userId);
    Task<BaseResponseGeneric<GlobalesAS>> GetByIdAsync(int id);
    Task<BaseResponseGeneric<ICollection<GlobalesAS>>> GetAllAsync(string userId);
    Task<BaseResponseGeneric<int>> CreateAsync(DtoGlobalesAS request,string userId);
    Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoGlobalesAS request , string userId);
}