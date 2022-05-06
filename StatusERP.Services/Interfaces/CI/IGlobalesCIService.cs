using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;


namespace StatusERP.Services.Interfaces.CI
{
    public interface IGlobalesCIService
    {
        Task<BaseResponseGeneric<ICollection<GlobalesCI>>> GetAsync( string userId);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoGlobalesCI request, string userId);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoGlobalesCI request, string userId);

    }
}

