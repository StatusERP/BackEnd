using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public class UsuarioPaqueteRepository : StatusERPContextBase<UsuarioPaquete>, IUsuarioPaqueteRepository
    {
        public UsuarioPaqueteRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<int> CreateAsync(UsuarioPaquete UsuarioPaquete)
        {
            return await _dbContext.InsertAsync(UsuarioPaquete);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new UsuarioPaquete
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<UsuarioPaquete?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<UsuarioPaquete>(id);
        }

        public async Task<ICollection<UsuarioPaquete>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<UsuarioPaquete>(page, rows);
        }

        public async Task<int> UpdateAsync(UsuarioPaquete UsuarioPaquete)
        {
            await _dbContext.UpdateAsync(UsuarioPaquete,Mapper);
            return UsuarioPaquete.Id;
        }
    }
}
