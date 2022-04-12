using StatusERP.Entities.ERPADMIN.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces
{
    public interface IPrivilegioUsuarioRepository
    {
        Task<ICollection<PrivilegioUsuario>> GetCollectionAsync(int page, int rows);
        Task<PrivilegioUsuario?> GetByIdAsync(int id);
        Task<PrivilegioUsuario?> GetPrivilegioUsuario(string constante,int conjuntoId, string UsuarioId);

        Task<int> CreateAsync(PrivilegioUsuario privilegioUsuario);
        Task<int> UpdateAsync(PrivilegioUsuario privilegioUsuario);
        Task<int> DeleteAsync(int id, string userId);
    }
}
