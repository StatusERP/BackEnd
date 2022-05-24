using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;


namespace StatusERP.Services.Interfaces.CI
{
    public interface IDocumentoInvEncService
    {
        Task<BaseResponseGeneric<ICollection<DocumentoInvEnc>>> GetAsync(int page, int rows, string userId);

        Task<BaseResponseGeneric<DocumentoInvEnc>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoDocumentoInvEnc request, string userId, string paquete, string documento);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoDocumentoInvEnc request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}
