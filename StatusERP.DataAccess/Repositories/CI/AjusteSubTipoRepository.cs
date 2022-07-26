using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class AjusteSubTipoRepository : StatusERPContextBase<AjusteSubTipo>, IAjusteSubTipoRepository
    {

        public AjusteSubTipoRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<AjusteSubTipo?> BuscarAjusteSubTipoAsync(string ajusteConfig, string subTipo)
        {
            return await _dbContext.AjustesSubTipo
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.AjusteConfig == ajusteConfig && t.SubTipo == subTipo);
        }

        public async Task<int> CreateAsync(AjusteSubTipo ajusteSubTipo)
        {
            return await _dbContext.InsertAsync(ajusteSubTipo);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new AjusteSubTipo
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<AjusteSubTipo?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<AjusteSubTipo>(id);
        }

        public async Task<ICollection<AjusteSubTipo>> GetCollectionAsync()
        {
            return await _dbContext.Set<AjusteSubTipo>()
              .Include(p=>p.AjusteConfigPK)
                .Where(p => !p.IsDeleted)
              .AsNoTracking()
               
              .ToListAsync();

            
        }

        public async Task<int> UpdateAsync(AjusteSubTipo ajusteSubTipo)
        {
            await _dbContext.UpdateAsync(ajusteSubTipo,Mapper);
            return ajusteSubTipo.Id;
        }
    }
}