using StatusERP.Entities.CG.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusERP.DataAccess.Repositories.CG
{
    public interface ITipoPartidaRepository
    {
        Task<ICollection<TipoPartida>> GetCollectionAsync(int page, int rows);
        Task<TipoPartida?> GetByIdAsync(int id);
        Task<TipoPartida?> BuscarCodTipoPartidadAsync(string codTipoPartida);
        Task<int> CreateAsync(TipoPartida tipoPartida);
        Task<int> UpdateAsync(TipoPartida tipoPartida);
        Task<int> DeleteAsync(int id, string userId);
    }
}
