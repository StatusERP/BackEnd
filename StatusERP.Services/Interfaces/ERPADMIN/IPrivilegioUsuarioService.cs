using StatusERP.Dto.Request.ERPADMIN;
using StatusERP.Dto.Response;
using StatusERP.Entities.ERPADMIN.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusERP.Services.Interfaces.ERPADMIN
{
    public interface IPrivilegioUsuarioService
    {
        Task<BaseResponseGeneric<ICollection<PrivilegioUsuario>>> GetAsync(int page, int rows);
        Task<BaseResponseGeneric<PrivilegioUsuario>> GetByIdAsync(int id);

        Task<BaseResponseGeneric<int>> CreateAsync(DtoPrivilegioUsuario request, string userId, string codBodega);

        Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoPrivilegioUsuario request, string userId);

        Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId);
        Task<BaseResponseGeneric<PrivilegioUsuario>> GetPrivilegioUsuario(string constante, int conjuntoId,  string UsuarioId);

    }
}
