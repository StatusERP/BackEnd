using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;


namespace StatusERP.Services.Interfaces.CI
{
    public interface IArticuloService
    {
        Task<BaseResponseGeneric<ICollection<Articulo>>> GetAsync(int page, int rows, string userId);

        Task<BaseResponseGeneric<Articulo>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoArticulo request, string userId, string codArticulo);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoArticulo request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);

        //Task<BaseResponseGeneric<int>> UsaLoteAsync(int id);
    }
}
