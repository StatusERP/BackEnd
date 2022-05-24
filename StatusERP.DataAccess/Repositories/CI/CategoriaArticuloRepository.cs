using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class CategoriaArticuloRepository : StatusERPContextBase<CategoriaArticulo>, ICategoriaArticuloRepository
    {

        public CategoriaArticuloRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<CategoriaArticulo?> BuscarCodCategoriaArticuloAsync(string CodCategoriaArticulo)
        {
            return await _dbContext.CategoriasArticulos
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodCategoriaArticulo == CodCategoriaArticulo);
        }

        public async Task<int> CreateAsync(CategoriaArticulo CategoriaArticulo)
        {
            return await _dbContext.InsertAsync(CategoriaArticulo);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new CategoriaArticulo
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<CategoriaArticulo?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<CategoriaArticulo>(id);
        }

        public async Task<ICollection<CategoriaArticulo>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<CategoriaArticulo>(page, rows);
        }

        public async Task<int> UpdateAsync(CategoriaArticulo CategoriaArticulo)
        {
            await _dbContext.UpdateAsync(CategoriaArticulo,Mapper);
            return CategoriaArticulo.Id;
        }
    }
}
