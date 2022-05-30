using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class CategoriaClienteRepository : StatusERPContextBase<CategoriaCliente>, ICategoriaClienteRepository
{
    public CategoriaClienteRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }


    public async Task<ICollection<CategoriaCliente>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<CategoriaCliente>(page, rows);
    }

    public async Task<CategoriaCliente?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<CategoriaCliente>(id);
    }

    public async Task<CategoriaCliente?> BuscarCodCategoriaClienteAsync(string codCategoriaCliente)
    {

        return await _dbContext.CategoriasCliente
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodCategoriaCliente == codCategoriaCliente);
    }


    public async Task<int> CreateAsync(CategoriaCliente CategoriaCliente)
    {
        return await _dbContext.InsertAsync(CategoriaCliente);
    }


    public async Task<int> UpdateAsync(CategoriaCliente categoriaCliente)
    {
        await _dbContext.UpdateAsync(categoriaCliente,Mapper);
        return categoriaCliente.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new CategoriaCliente
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }
}