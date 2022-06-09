using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;


namespace StatusERP.Services.Interfaces.CI
{
    public interface ILoteService
    {
        Task<BaseResponseGeneric<ICollection<Lote>>> GetAsync(int page, int rows, string userId);

        Task<BaseResponseGeneric<Lote>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoLote request, string userId, string codLote, int ArticuloId);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoLote request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}

