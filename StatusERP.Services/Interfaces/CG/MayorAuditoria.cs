using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;


namespace StatusERP.Services.Interfaces.CG
{
    public interface IMayorAuditoriaService
    {
        Task<BaseResponseGeneric<ICollection<MayorAuditoria>>> GetAsync(int page, int rows);

        Task<BaseResponseGeneric<MayorAuditoria>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoMayorAuditoria request, string userId, string codMayorAuditoria);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoMayorAuditoria request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}