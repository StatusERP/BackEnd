using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class AjusteSubSubTipoRepository : StatusERPContextBase<AjusteSubSubTipo>, IAjusteSubSubTipoRepository
    {

        public AjusteSubSubTipoRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<AjusteSubSubTipo?> BuscarAjusteSubSubTipoAsync(string ajusteConfig, string SubSubTipo)
        {
            return await _dbContext.AjustesSubSubTipo
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.AjusteConfig == ajusteConfig && t.Subsubtipo == SubSubTipo);
        }

        public async Task<int> CreateAsync(AjusteSubSubTipo ajusteSubSubTipo)
        {
            return await _dbContext.InsertAsync(ajusteSubSubTipo);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new AjusteSubSubTipo
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<AjusteSubSubTipo?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<AjusteSubSubTipo>(id);
        }

        public async Task<ICollection<AjusteSubSubTipo>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<AjusteSubSubTipo>(page, rows);
        }

        public async Task<int> UpdateAsync(AjusteSubSubTipo ajusteSubSubTipo)
        {
            await _dbContext.UpdateAsync(ajusteSubSubTipo);
            return ajusteSubSubTipo.Id;
        }
    }
}