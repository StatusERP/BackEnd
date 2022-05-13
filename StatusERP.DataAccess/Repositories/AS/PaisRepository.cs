using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Entities.AS.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusERP.DataAccess.Repositories.AS
{
    public class PaisRepository : StatusERPContextBase<Pais>, IPaisRepository
    {
        public PaisRepository(StatusERPDBContext context,IMapper mapper):base(context,mapper)
        {

        }
        public async Task<Pais?> BuscarCodPaisAsync(string codPais)
        {
            return await _dbContext.Paises
          .AsNoTracking()
          .FirstOrDefaultAsync(t => t.CodPais == codPais);
        }
            public async Task<int> CreateAsync(Pais pais)
        {
            return await _dbContext.InsertAsync(pais);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new Pais
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<Pais?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<Pais>(id);
        }

        public async Task<ICollection<Pais>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<Pais>(page, rows);
        }

        public  async Task<int> UpdateAsync(Pais pais)
        {
            await _dbContext.UpdateAsync(pais);
            return pais.Id;
        }
    }
}
