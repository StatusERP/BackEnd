using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class CategoriaProveedorRepository : StatusERPContextBase<CategoriaProveedor>, ICategoriaProveedorRepository
{
    public CategoriaProveedorRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }


    public async Task<ICollection<CategoriaProveedor>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<CategoriaProveedor>(page, rows);
    }

    public async Task<CategoriaProveedor?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<CategoriaProveedor>(id);
    }

    public async Task<CategoriaProveedor?> BuscarCodCategoriaProveedorAsync(string codCategoriaProveedor)
    {

        return await _dbContext.CategoriasProveedor
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodCategoriaProveedor == codCategoriaProveedor);
    }


    public async Task<int> CreateAsync(CategoriaProveedor categoriaProveedor)
    {
        return await _dbContext.InsertAsync(categoriaProveedor);
    }


    public async Task<int> UpdateAsync(CategoriaProveedor categoriaProveedor)
    {
        await _dbContext.UpdateAsync(categoriaProveedor);
        return categoriaProveedor.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new CategoriaProveedor
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }
}