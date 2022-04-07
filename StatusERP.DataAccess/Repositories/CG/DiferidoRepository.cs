using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public class DiferidoRepository : StatusERPContextBase<Diferido>, IDiferidoRepository
    {

        public DiferidoRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<Diferido?> BuscarCodDiferidoAsync(string CodDiferido)
        {
            return await _dbContext.Diferidos
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodDiferido == CodDiferido);
        }

        public async Task<int> CreateAsync(Diferido Diferido)
        {
            return await _dbContext.InsertAsync(Diferido);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new Diferido
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<Diferido?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<Diferido>(id);
        }

        public async Task<ICollection<Diferido>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<Diferido>(page, rows);
        }

        public async Task<int> UpdateAsync(Diferido Diferido)
        {
            await _dbContext.UpdateAsync(Diferido, Mapper);
            return Diferido.Id;
        }
    }
}