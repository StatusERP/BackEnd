using StatusERP.Entities.AS.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusERP.DataAccess.Repositories.AS.Interfaces
{
    public interface IPaisRepository
    {
        Task<ICollection<Pais>> GetCollectionAsync(int page, int rows);
        Task<Pais?> GetByIdAsync(int id);
        Task<Pais?> BuscarCodPaisAsync(string codPais);
        Task<int> CreateAsync(Pais pais);
        Task<int> UpdateAsync(Pais pais);
        Task<int> DeleteAsync(int id, string userId);
      
    }
}
