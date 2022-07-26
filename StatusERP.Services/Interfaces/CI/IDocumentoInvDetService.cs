using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;


namespace StatusERP.Services.Interfaces.CI
{
    public interface IDocumentoInvDetService
    {
        Task<BaseResponseGeneric<ICollection<DocumentoInvDet>>> GetAsync(int page, int rows, string userId);

        Task<BaseResponseGeneric<DocumentoInvDet>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoDocumentoInvDet request, string userId, int paquete, string documento, int linea);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoDocumentoInvDet request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
    }
}

