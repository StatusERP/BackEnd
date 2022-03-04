﻿using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Interfaces.AS
{
    public interface IVendedorService
    {
        Task<BaseResponseGeneric<ICollection<Vendedor>>> GetAsync( int page, int rows);
        Task<BaseResponseGeneric<Vendedor>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoVendedor request,string userId);
        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoVendedor request , string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id);

    }

}
