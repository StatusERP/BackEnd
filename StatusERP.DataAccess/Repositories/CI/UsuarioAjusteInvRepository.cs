using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class UsuarioAjusteInvRepository : StatusERPContextBase<UsuarioAjusteInv>, IUsuarioAjusteInvRepository
    {

        public UsuarioAjusteInvRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<UsuarioAjusteInv?> BuscarUsuarioAjusteInvAsync(string usuario, int ajusteConfig)
        {
            return await _dbContext.UsuarioAjusteInv
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.Usuario == usuario  && t.AjusteConfig == ajusteConfig);
        }

        public async Task<int> CreateAsync(UsuarioAjusteInv usuarioAjusteInv)
        {
            return await _dbContext.InsertAsync(usuarioAjusteInv);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new UsuarioAjusteInv
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<UsuarioAjusteInv?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<UsuarioAjusteInv>(id);
        }

        public async Task<ICollection<UsuarioAjusteInv>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<UsuarioAjusteInv>(page, rows);
        }

        public async Task<int> UpdateAsync(UsuarioAjusteInv usuarioAjusteInv)
        {
            await _dbContext.UpdateAsync(usuarioAjusteInv);
            return usuarioAjusteInv.Id;
        }
    }
}
