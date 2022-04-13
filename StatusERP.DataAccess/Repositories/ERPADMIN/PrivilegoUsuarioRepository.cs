using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Entities.ERPADMIN.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusERP.DataAccess.Repositories.ERPADMIN
{
    public class PrivilegoUsuarioRepository : StatusERPContextBase<PrivilegioUsuario>, IPrivilegioUsuarioRepository
    {
        public PrivilegoUsuarioRepository(StatusERPDBContext context, IMapper mapper):base(context, mapper)
        {

        }
        public Task<int> CreateAsync(PrivilegioUsuario privilegioUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id, string userId)
        {
            throw new NotImplementedException();
        }

     

        public Task<PrivilegioUsuario?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<PrivilegioUsuario>> GetCollectionAsync(int page, int rows)
        {
            throw new NotImplementedException();
        }

        public async Task<PrivilegioUsuario?> GetPrivilegioUsuario(string constante, int conjuntoId,  string UsuarioId)
        {

            return await _dbContext.PrivilegioUsuario
                .AsNoTracking()
                .Include(s=>s.Accion)
                .Where(c=>c.Accion.NombreConstante == constante)
                .FirstOrDefaultAsync(t =>t.ConjuntoId  ==conjuntoId &&  t.UsuarioId==UsuarioId );
        }

        public Task<int> UpdateAsync(PrivilegioUsuario privilegioUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
