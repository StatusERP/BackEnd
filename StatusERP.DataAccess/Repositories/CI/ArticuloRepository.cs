using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class ArticuloRepository : StatusERPContextBase<Articulo>, IArticuloRepository
    {

        public ArticuloRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<Articulo?> BuscarCodArticuloAsync(string CodArticulo)
        {
            return await _dbContext.Articulos
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodArticulo == CodArticulo);
        }

        public async Task<int> CreateAsync(Articulo articulo)
        {
            return await _dbContext.InsertAsync(articulo);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new Articulo
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<Articulo?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<Articulo>(id);
        }

        public async Task<ICollection<Articulo>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<Articulo>(page, rows);
        }

        public async Task<int> UpdateAsync(Articulo Articulo)
        {
            await _dbContext.UpdateAsync(Articulo, Mapper);
            return Articulo.Id;
        }
    }
}
