using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;


namespace StatusERP.Services.Interfaces.CI
{
    public interface ICategoriaArticuloService
    {
        Task<BaseResponseGeneric<ICollection<CategoriaArticulo>>> GetAsync(int page, int rows, string userId);

        Task<BaseResponseGeneric<CategoriaArticulo>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoCategoriaArticulo request, string userId, string codCategoríaArticulo);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoCategoriaArticulo request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}