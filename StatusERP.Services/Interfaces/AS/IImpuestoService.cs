using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;


namespace StatusERP.Services.Interfaces.AS
{
    public interface IImpuestoService
    {
        Task<BaseResponseGeneric<ICollection<Impuesto>>> GetAsync(int page, int rows, string userId);

        Task<BaseResponseGeneric<Impuesto>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoImpuesto request, string userId, string codImpuesto);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoImpuesto request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}

