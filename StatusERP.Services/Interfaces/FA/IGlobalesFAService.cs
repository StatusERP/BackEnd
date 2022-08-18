using StatusERP.Dto.Request.FA;
using StatusERP.Dto.Response;
using StatusERP.Entities.FA.Tablas;


namespace StatusERP.Services.Interfaces.FA
{
    public interface IGlobalesFAService
    {
        Task<BaseResponseGeneric<ICollection<GlobalesFA>>> GetAsync(string userId);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoGlobalesFA request, string userId);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoGlobalesFA request, string userId);

    }
}

